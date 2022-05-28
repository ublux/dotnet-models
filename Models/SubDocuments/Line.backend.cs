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
        return GetIdPhone(this.Id);
    }

    /// <summary>
    ///     Id of line is composed of prefix:lineIndex:{phoneId}. Because of this reason it is posible to obain id of phone
    /// </summary>
    public static string GetIdPhone(string idLine)
    {
        // Example of line id:   Li:0:Ph:1000
        // this will return therefore Ph:1000
        return idLine[(DocumentPrefix.Length + 3)..];
    }
}

#endif