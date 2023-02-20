#if UBLUX_BACKEND

using Microsoft.Toolkit.HighPerformance;

namespace Ublux.Communications.Models.SubDocuments;

/// <summary>
///     It is part of a phone. Lines are needed in order to make and receive phone calls.
/// </summary>
public partial class Line : UbluxSubDocument
{
    /// <summary>
    ///     Id of line is composed of prefix:{phoneId}.lineIndex Because of this reason it is posible to obain id of phone
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
        // Example of line id:   Li.Ph.1.AZ100.23
        // this will return therefore Ph.1.AZ100  that means Phone created by instance 1 and idcounter AZ100
        if (idLine == null)
            return null;

        var numDots = idLine.Count('.');
        if (numDots < 4)
        {
            // invalid id of line
            return null;
        }

        int firstDotIndex = DocumentPrefix.Length + 1;
        int lastDotIndex = idLine.LastIndexOf(RedisConstants.DelimeterId);
        string result = idLine.Substring(firstDotIndex, lastDotIndex - firstDotIndex);

        return result;
    }
}

#endif