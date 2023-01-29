#if UBLUX_BACKEND

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
}

#endif