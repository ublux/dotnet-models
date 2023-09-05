namespace Ublux.Communications.Enums;

/// <summary>
///     Type of AI variable
/// </summary>
public enum AiVariableType
{
    /// <summary>
    ///     No type
    /// </summary>
    None,

    /// <summary>
    ///     String or text. Example. "summary of conversation is ..."
    /// </summary>
    Text,

    /// <summary>
    ///     Integer values. ...-2,-1,0,1,2...
    /// </summary>
    Integer,

    /// <summary>
    ///     Decimal values. Examples: -1.2, 0, 1.5, 100.12345
    /// </summary>
    Decimal,

    /// <summary>
    ///     Yes or no
    /// </summary>
    Boolean,

    /// <summary>
    ///     Example: { Positive: 90, Neutral : 2, Negative : 8 }
    ///     Values range from 0 to 100
    /// </summary>
    Sentiments,

    /// <summary>
    ///     Example: { EntityType : Location, EntityName : Hotel }   
    /// </summary>
    Entities,

    /// <summary>
    ///     Example: { Name : "Loud Party", Weight : 0.8 }   
    ///     Eeight is decimal value from 0 to 1
    /// </summary>
    Topics   
}
