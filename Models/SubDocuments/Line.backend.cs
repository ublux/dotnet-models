#if UBLUX_BACKEND

namespace Ublux.Communications.Models.SubDocuments;

/// <summary>
///     It is part of a phone. Lines are needed in order to make and receive phone calls.
/// </summary>
public partial class Line : UbluxSubDocument
{
    /// <summary>
    ///     Id of line is composed of prefix:lineIndex:{phoneId}. Because of this reason it is posible to obain id of phone
    /// </summary>
    public string GetIdPhone()
    {
        return GetIdPhone(this.Id) ?? throw new Exception($"invalid id of line {this.Id}");
    }

    /// <summary>
    ///     Id of line is composed of prefix:lineIndex:{phoneId}. Because of this reason it is posible to obain id of phone
    /// </summary>
    public static string? GetIdPhone(string idLine)
    {
        // Example of line id:   Li.AZ100.Ph.1.23
        // this will return therefore Ph.1.23
        if (idLine == null)
            return null;

        var index = idLine.IndexOf(RedisConstants.DelimeterId, DocumentPrefix.Length + 1);
        if (index > 0)
            return idLine[(index + 1)..];
        else
            return null;
    }
}

#endif