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
    ///     Id of line is composed of prefix:IdAcc:IdPhone:IdGlobalCounter. In here we get
    /// </summary>
    public static string? GetIdPhone(string idLine)
    {
        // string input = "Li.Ac.1.Ph.WS1.8.9";
        byte dotCount = 0;
        byte[] dots = new byte[6];

        for (byte i = 2; i < idLine.Length; i++)
            if (idLine[i] == '.')
            {
                dots[dotCount++] = i;
                if (dotCount == dots.Length)
                    break;
            }

        // id phone will be the index from dot 3 to 6
        var idPhone = idLine[(dots[2] + 1)..dots[5]];
        return idPhone;

        //// Example of line id:   Li.Ph.1.AZ100.23
        //// this will return therefore Ph.1.AZ100  that means Phone created by instance 1 and idcounter AZ100
        //if (idLine == null)
        //    return null;

        //var numDots = idLine.Count('.');
        //if (numDots < 4)
        //{
        //    // invalid id of line
        //    return null;
        //}

        //int firstDotIndex = DocumentPrefix.Length + 1;
        //int lastDotIndex = idLine.LastIndexOf(RedisConstants.DelimeterId);
        //string result = idLine.Substring(firstDotIndex, lastDotIndex - firstDotIndex);

        //return result;
    }

    /// <summary>
    ///     Id of line is composed of prefix:lineIndex:{phoneId}. Because of this reason it is posible to obain id of phone
    /// </summary>
    public static string? GetIdAccount(string idLine)
    {
        // string input = "Li.Ac.1.Ph.WS1.8.9";
        byte lastDot = 0;
        for (byte i = 7; i < idLine.Length; i++)
            if (idLine[i] == '.')
            {
                lastDot = i;
                break;
            }

        // id account will be substring in btween dot 1 and
        var idAccount = idLine[3..lastDot];
        return idAccount;

    }
}

#endif