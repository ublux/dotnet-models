#if UBLUX_BACKEND

using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Previously called IpPhone. Represents a phone in UBLUX
/// </summary>
public partial class Phone
{
    //private static readonly ReaderWriterLockSlim _lock = new();

    /// <summary>
    ///     If true it will be sync with API because line status changed
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    [JsonIgnore]
    [BsonIgnore]
    [HideForCreateRequest]
    public bool IsConnectionStatusChanged;

    /// <summary>
    ///     Password of phone used to authenticate with asterisk
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [UbluxValidationStringRange(8, 50)]
    public required string Password
    {
        get; 
        
        // Password should not change after it is set
#if UBLUX_Release || RELEASE
        set;
#else
        init;
#endif

    } = string.Empty;

    /// <summary>
    ///     Set password
    /// </summary>
    /// <param name="newPass"></param>
    [Obsolete("This is just to give a warning. Should only update the password when receiving an object from API and setting a new password")]
    public void SetPassword(string newPass)
    {
        var prop = this.GetType().GetProperty(nameof(Password))!;
        prop.SetValue(this, newPass);
    }


    // /// <summary>
    // ///     Autoprovision-id. We use this instead of the mac address of the phone.
    // ///     1) Mac address can change if phone is connected from ethernet and then WiFi
    // ///     2) This way we can be certain that if we receive this request its not a hacker
    // /// </summary>
    // [UbluxValidationRequired]
    // [AllowUpdate(false)]
    // [SwaggerSchema(ReadOnly = true)]
    // [IgnoreDataMember]
    // [UbluxValidationStringRange(8, 50)]
    // public required string AutoprovisionId { get; set; } = string.Empty;

    /// <summary>
    ///     Build an autoprovision id
    /// </summary>
    public static string BuildAutoprovisionId(string idAccount)
    {
        return $"{idAccount}-{Phone.GetRandomPassword(12, false)}";
    }

    /// <summary>
    ///     It is ok to have it hardcoded. If we change this unit test will fail
    ///     Ph | Ac.1 | API1 | 10000
    /// </summary>
    public const string Regex_GetIdOfPhonePattern = @"Ph\.Ac\.\d+\.[^\.]+\.\w{1,12}";

    /// <summary>
    ///     For now it is: Li.Ac.1111.Ph.API-1111.81111.91111
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
    public static string GetRandomPassword(int length = 16, bool includeSpecialCharacters = true)
    {
        // Maybe RandomNumberGenerator is thread safe but just to be sure
        lock (alphanumericMainCharacters)
        {
            char[] p = new char[length];
            if (includeSpecialCharacters)
            {
                for (int i = 0; i < length; i++)
                    p[i] = alphanumericAllCharacters[RandomNumberGenerator.GetInt32(0, alphanumericAllCharacters.Length)];
            }
            else
            {
                for (int i = 0; i < length; i++)
                    p[i] = alphanumericMainCharacters[RandomNumberGenerator.GetInt32(0, alphanumericMainCharacters.Length)];
            }
            
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
        if (PhoneConnectionStatus is null)
            return false;
        return PhoneConnectionStatus.IsConnected;
    }

    /// <summary>
    ///     Ids of phones contain id of phone embedded
    /// </summary>
    public static string GetIdAccountFromId(string idPhone)
    {
        // string input = "Ph.Ac.1.API.1000";

        var start = DocumentPrefix.Length + Account.DocumentPrefix.Length + 3;

        var thirdDot = start + idPhone[start..].IndexOf(RedisConstants.DelimiterId);

        // id account will be substring in between dot 1 and
        var idAccount = idPhone[(DocumentPrefix.Length + 1)..thirdDot];

        return idAccount;
    }

    /// <summary>
    ///     Get caller id number
    /// </summary>
    public string GetCallerIdNumber(ILogger logger)
    {
        if (CallerIdNumbers.Count == 0)
            return "";

        if (CallerIdIndex < CallerIdNumbers.Count)
            return CallerIdNumbers[CallerIdIndex];

        logger.Log(LogLevel.Error, 374827381, "Caller id index is outside of range for phone {id}. Setting first one", id);
        return CallerIdNumbers[0];
    }

}

#endif