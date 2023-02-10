#if UBLUX_BACKEND

using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Previously called IpPhone. Represents a phone in UBLUX
/// </summary>
public partial class Phone : UbluxDocument, IReferncesAccount
{
    /// <summary>
    ///     Points to what account?
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string IdAccount { get; set; } = string.Empty;

    /// <summary>
    ///     Password of phone used to authenticate with asterisk
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public required string Password { get; set; } = string.Empty;

    /// <summary>
    ///     For now it is: Li\.[a-zA-Z0-9\.]+
    /// </summary>
    [GeneratedRegex($@"{Line.DocumentPrefix}{RedisConstants.DelimeterEscaped}[a-zA-Z0-9{RedisConstants.DelimeterEscaped}]+")]
    public static partial Regex Regex_GetIdOfLine();

    private const string alphanumericCharacters =
           "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
           "abcdefghijklmnopqrstuvwxyz" +
           "0123456789" +
           "!@#$%.-_"
           ;
    /// <summary>
    ///     Generate a new random password for a phone
    /// </summary>
    public static string GetRandomPassword(int length = 16)
    {
        char[] p = new char[length];
        for (int i = 0; i < length; i++)
            p[i] = alphanumericCharacters[RandomNumberGenerator.GetInt32(0, alphanumericCharacters.Length)];
        return new string(p);
    }

    /// <summary>
    ///     Generates a random phone pin
    /// </summary>
    public static string GenerateRandomPhonePin()
    {
        return Random.Shared.Next(10000, 99999).ToString();
    }
}

#endif