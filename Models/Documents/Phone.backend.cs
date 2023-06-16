#if UBLUX_BACKEND

using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Previously called IpPhone. Represents a phone in UBLUX
/// </summary>
public partial class Phone
{
    /// <summary>
    ///     Password of phone used to authenticate with asterisk
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [UbluxValidationStringRange(8, 50)]
    public required string Password { get; set; } = string.Empty;

    /// <summary>
    ///     It is ok to have it hardcoded. If we change this unit test will fail
    ///     Ph | Ac.1 | WS1 | 10000
    /// </summary>
    public const string Regex_GetIdOfPhonePattern = @"Ph\.Ac\.\d+\.[^\.]+\.\w{1,12}";

    /// <summary>
    ///     For now it is: Li.Ac.1111.Ph.WS-1111.81111.91111
    ///     It is ok to hard code it. If prefixis change unit tests will fail. It is very important to keep running unit tests!
    /// </summary>
    [GeneratedRegex(Regex_GetIdOfPhonePattern)]
    public static partial Regex Regex_GetIdOfPhone();

    internal const string alphanumericMainCharacters =
           "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
           "abcdefghijklmnopqrstuvwxyz" +
           "0123456789"
           ;

    internal const string alphanumericSpecialCharacters =
           "!@#$%.-_"
           ;

    internal const string alphanumericAllCharacters =
           alphanumericMainCharacters +
           alphanumericSpecialCharacters
           ;

    /// <summary>
    ///     Generate a new random password for a phone
    /// </summary>
    public static string GetRandomPassword(int length = 16)
    {
        // Maybe RandomNumberGenerator is thread safe but just to be sure
        lock (alphanumericMainCharacters)
        {
            char[] p = new char[length];
            for (int i = 0; i < length; i++)
                p[i] = alphanumericAllCharacters[RandomNumberGenerator.GetInt32(0, alphanumericAllCharacters.Length)];
            return new string(p);
        }
    }

    /// <summary>
    ///     Generates a random phone pin
    /// </summary>
    public static string GenerateRandomPhonePin()
    {
        // This is thread safe
        return Random.Shared.Next(10000, 99999).ToString();
    }

    /// <summary>
    ///     Helper method to see if any of the lines are connected
    /// </summary>
    public bool IsConnected()
    {
        if (this.PhoneConnectionStatus is null)
            return false;
        return this.PhoneConnectionStatus.IsConnected;
    }

}

#endif