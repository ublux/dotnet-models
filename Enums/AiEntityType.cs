namespace Ublux.Communications.Enums;

/// <summary>
///     AI entity detection entity types
/// </summary>
public enum AiEntityType
{
    /// <summary> People, including fictional. Example: Paul McCartney, Fred Flinstone </summary>
    PERSON,

    /// <summary> Nationalities, religious or political groups. Example: The Republican Party </summary>
    NORP,

    /// <summary> Buildings, airports, highways, bridges. Example: Golden Gate, Miami International Airport </summary>
    FAC,

    /// <summary> Companies, agencies, institutes. Example: Microsoft, FBI, MIT </summary>
    ORG,

    /// <summary> Countries, cities, states. Example: France, Florida, Acapulco </summary>
    GPE,

    /// <summary> Non-GPE locations, mountain ranges, bodies of water. Example: Europe, Nile River, Midwest </summary>
    LOC,

    /// <summary> Objects, vehicles, foods, etc. (not services). Example: Formula 1 </summary>
    PRODUCT,

    /// <summary> Named hurricanes, sport events, battles, wars. Example: Olympic Games </summary>
    EVENT,

    /// <summary> Titles of books, songs, paintings, etc.. Example: The Mona Lisa </summary>
    WORK_OF_ART,

    /// <summary> Named documents made into laws. Example: Roe v. Wade </summary>
    LAW,

    /// <summary> Any named language. Example: English, Spanish </summary>
    LANGUAGE,

    /// <summary> Absolute or relative dates or periods. Example: 28 April 2022, two weeks </summary>
    DATE,

    /// <summary> Times smaller than a day. Example: four hours </summary>
    TIME,

    /// <summary> Percentage, including '%'. Example: eighty percent, 75% </summary>
    PERCENT,

    /// <summary> Monetary values, including unit. Example: Twenty cents </summary>
    MONEY,

    /// <summary> Measurements, as of weight or distance. Example: Several kilometers, 55 kg </summary>
    QUANTITY,

    /// <summary> Ordinal number. Example: First, 9th </summary>
    ORDINAL,

    /// <summary> Numerals outside other categories. Example: 2, Two </summary>
    CARDINAL,
}
