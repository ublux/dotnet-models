namespace Ublux.Communications.Models;

/// <summary>
///     Constants
/// </summary>
public class RedisConstants
{
    #region Redis delimeters

    /// <summary>
    ///     Delimeter used to split ids
    /// </summary>
    public const char DelimeterId = '.';

    /// <summary>
    ///     Delimeter used for set. Example Phones:Ac.1
    /// </summary>
    public const char DelimeterSet = ':';

    /// <summary>
    ///     Delimeter used for streams. For example: modified:1 maning one item was modified. That stream will contain info of object that got modified
    /// </summary>
    public const char DelimeterEvents = ':';

    #endregion

    
    // streams
    /// <summary>
    ///     Modified stream must start with this prefix
    /// </summary>
    public const string StreamModified = "stream:modified";
    /// <summary>
    ///     
    /// </summary>
    public const string StreamDeleted = "stream:deleted";

    /// <summary>
    ///     All channel events must start with this prefix
    /// </summary>
    public const string EventsChannel = "channel:events";

    /// <summary>
    ///     All hash sets on redis must start with this prefix
    /// </summary>
    public const string Set = "set";
}
