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
    [IsUbluxRequired]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]    
    public required string Password { get; set; } = string.Empty;
    

    /// <summary>
    ///     For now it is: Li\.[a-zA-Z0-9\.]+
    /// </summary>
    [GeneratedRegex($@"{Line.DocumentPrefix}{RedisConstants.DelimeterEscaped}[a-zA-Z0-9{RedisConstants.DelimeterEscaped}]+")]
    public static partial Regex Regex_GetIdOfLine();

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

    
}

#endif