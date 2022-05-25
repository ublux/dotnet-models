namespace Ublux.Communications.Models;

/// <summary>
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database. 
///     Business Logic Models that we work with inherit from this. 
///     We need to work with what is stored on our application. 
///     DTO objects is what we present to clients
/// </summary>
public partial interface IUbluxDocument : IUbluxDocumentId
{
    /// <summary>
    ///     Creation date
    /// </summary>
    [AllowUpdate(false)]
    [JsonProperty(Order = 1000)]
    [IsRequired]
    DateTime DateCreated { get; set; }

    /// <summary>
    ///     If collection is immutable this is not needed but we have it regardless
    /// </summary>
    [AllowUpdate(false)]
    [JsonProperty(Order = 1002)]
    DateTime? DateUpdated { get; set; }
}

/// <summary>
///     * This are business logic objects *
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database
/// </summary>
public abstract partial class UbluxDocument : IUbluxDocument, IUbluxDocumentId
{
    /// <summary>
    ///     Id of document
    /// </summary>
    [BsonId]
    [BsonElement(Order = -1000000)]
    [JsonProperty(Order = -1000)]
    [IsRequired]
    [HideForCreateRequest]
    [AllowUpdate(true)] // allow update will include property.
                        // This property is needed in order to know what document will be updated
    public string Id { get; set; } = String.Empty;

    /// <summary>
    ///     Creation date
    /// </summary>
    [JsonProperty(Order = 1000)]
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public DateTime DateCreated { get; set; }

    /// <summary>
    ///     Updated date
    /// </summary>
    [JsonProperty(Order = 1002)]
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public DateTime? DateUpdated { get; set; }

    // add: `-=[];',./~!@#$%^&*()_+{}|:<>?
    // to make it base92
    private const string charsString = @"0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    static readonly char[] base62Chars = charsString.ToCharArray();
    static readonly ulong base62CharsLength = (ulong)base62Chars.Length;

    /// <summary>
    ///     Convert from base62 string. 0=0 1=1 Z=61 10=62
    /// </summary>
    public static ulong FromBase62(string input)
    {
        ulong r = 0;
        int ctr = 0;

        for (var i = input.Length; i > 0; i--)
        {
            // 0 = 48
            // A = 65
            // a = 97
            var currChar = input[i - 1];
            var val = (ulong)charsString.IndexOf(currChar);

            if (ctr == 0)
                r = val;
            else
            {
                ulong tmp = base62CharsLength;
                for (int k = 1; k < ctr; k++)
                    tmp *= base62CharsLength;

                r += (val * tmp);
            }

            ctr++;
        }

        return r;
    }

    /// <summary>
    /// 0 = 0
    /// ...
    /// 9 = 9
    /// 10 = a
    /// 35 = Z
    /// </summary>
    public static string ToBase62(ulong input)
    {
        Span<char> result = stackalloc char[11];
        //char[] result = new char[6];

        //List<char> result = new List<char>();
        // max of 10 iterations because ulong.maxValue to base 62 is 10 characters long
        for (int i = 10; ; i--)
        {
            ulong reminder = input % base62CharsLength;
            input /= base62CharsLength;
            result[i] = base62Chars[reminder];

            if (input == 0)
                return new string(result[i..]);
        }
    }
}

/// <summary>
///     All ublux documents should have this id
/// </summary>
public interface IUbluxDocumentId
{
    /// <summary>
    ///     Id of document
    /// </summary>
    [BsonId]
    [JsonProperty(Order = -1000)]
    [BsonElement(Order = -1000000)]
    [AllowUpdate(true)] // set to true because property id is needed on auto-generated objects    
    [IsRequired]
    [HideForCreateRequest]
    string Id { get; set; }
}
