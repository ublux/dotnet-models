// ReSharper disable InconsistentNaming
namespace Ublux.Communications.Enums;

/// <summary>
///     Remember there is an ALL flag and also Unknown
///     // :Geo-Permissions
///     https://www.nationsonline.org/oneworld/country_code_list.htm
/// </summary>
public enum CountryIsoCode
{
    /// <summary>
    ///     No country
    /// </summary>
    None = 0,

    /// <summary>
    ///     United States
    /// </summary>
    US = 1,

    ///// <summary>
    /////     Canada
    ///// </summary>
    //CA = 1,

    /// <summary>
    ///     Bahamas
    /// </summary>
    BS = 1242,

    /// <summary>
    ///     Barbados
    /// </summary>
    BB = 1246,

    /// <summary>
    ///     Anguilla
    /// </summary>
    AI = 1264,

    /// <summary>
    ///     Antigua and Barbuda
    /// </summary>
    AG = 1268,

    /// <summary>
    ///     British Virgin Islands
    /// </summary>
    VG = 1284,

    /// <summary>
    ///     U.S. Virgin Islands
    /// </summary>
    VI = 1340,

    /// <summary>
    ///     Cayman Islands
    /// </summary>
    KY = 1345,

    /// <summary>
    ///     Bermuda
    /// </summary>
    BM = 1441,

    /// <summary>
    ///     Grenada
    /// </summary>
    GD = 1473,

    /// <summary>
    ///     Turks and Caicos Islands
    /// </summary>
    TC = 1649,

    /// <summary>
    ///     Montserrat
    /// </summary>
    MS = 1664,

    /// <summary>
    ///     Northern Mariana Islands
    /// </summary>
    MP = 1670,

    /// <summary>
    ///     Guam
    /// </summary>
    GU = 1671,

    /// <summary>
    ///     American Samoa
    /// </summary>
    AS = 1684,

    /// <summary>
    ///     Sint Maarten
    /// </summary>
    SX = 1721,

    /// <summary>
    ///     Saint Lucia
    /// </summary>
    LC = 1758,

    /// <summary>
    ///     Dominica
    /// </summary>
    DM = 1767,

    /// <summary>
    ///     Saint Vincent and the Grenadines
    /// </summary>
    VC = 1784,

    /// <summary>
    ///     Trinidad and Tobago
    /// </summary>
    TT = 1868,

    /// <summary>
    ///     Saint Kitts and Nevis
    /// </summary>
    KN = 1869,

    /// <summary>
    ///     Jamaica
    /// </summary>
    JM = 1876,

    /// <summary>
    ///     Puerto Rico
    /// </summary>
    PR1 = 1787,

    /// <summary>
    ///     Puerto Rico
    /// </summary>
    PR2 = 1939,

    /// <summary>
    ///     Dominican Republic
    /// </summary>
    DO1 = 1809,

    /// <summary>
    ///     Dominican Republic
    /// </summary>
    DO2 = 1829,

    /// <summary>
    ///     Dominican Republic
    /// </summary>
    DO3 = 1849,

    /// <summary>
    ///     Egypt
    /// </summary>
    EG = 20,

    /// <summary>
    ///     South Africa
    /// </summary>
    ZA = 27,

    /// <summary>
    ///     Greece
    /// </summary>
    GR = 30,

    /// <summary>
    ///     Netherlands
    /// </summary>
    NL = 31,

    /// <summary>
    ///     Belgium
    /// </summary>
    BE = 32,

    /// <summary>
    ///     France
    /// </summary>
    FR = 33,

    /// <summary>
    ///     Spain
    /// </summary>
    ES = 34,

    /// <summary>
    ///     Hungary
    /// </summary>
    HU = 36,

    /// <summary>
    ///     Italy
    /// </summary>
    IT = 39,

    /// <summary>
    ///     Romania
    /// </summary>
    RO = 40,

    /// <summary>
    ///     Switzerland
    /// </summary>
    CH = 41,

    /// <summary>
    ///     Austria
    /// </summary>
    AT = 43,

    /// <summary>
    ///     United Kingdom
    /// </summary>
    GB = 44,

    /// <summary>
    ///     Denmark
    /// </summary>
    DK = 45,

    /// <summary>
    ///     Sweden
    /// </summary>
    SE = 46,

    /// <summary>
    ///     Norway
    /// </summary>
    NO = 47,

    ///// <summary>
    /////     Svalbard and Jan Mayen
    ///// </summary>
    //SJ = 47,

    /// <summary>
    ///     Poland
    /// </summary>
    PL = 48,

    /// <summary>
    ///     Germany
    /// </summary>
    DE = 49,

    /// <summary>
    ///     Peru
    /// </summary>
    PE = 51,

    /// <summary>
    ///     Mexico
    /// </summary>
    MX = 52,

    /// <summary>
    ///     Cuba
    /// </summary>
    CU = 53,

    /// <summary>
    ///     Argentina
    /// </summary>
    AR = 54,

    /// <summary>
    ///     Brazil
    /// </summary>
    BR = 55,

    /// <summary>
    ///     Chile
    /// </summary>
    CL = 56,

    /// <summary>
    ///     Colombia
    /// </summary>
    CO = 57,

    /// <summary>
    ///     Venezuela
    /// </summary>
    VE = 58,

    /// <summary>
    ///     Malaysia
    /// </summary>
    MY = 60,

    /// <summary>
    ///     Australia
    /// </summary>
    AU = 61,

    ///// <summary>
    /////     Christmas Island
    ///// </summary>
    //CX = 61,

    // This islands are from Australia 
    ///// <summary>
    /////     Cocos Islands
    ///// </summary>
    //CC = 61,

    /// <summary>
    ///     Indonesia
    /// </summary>
    ID = 62,

    /// <summary>
    ///     Philippines
    /// </summary>
    PH = 63,

    /// <summary>
    ///     New Zealand
    /// </summary>
    NZ = 64,

    ///// <summary>
    /////     Pitcairn
    ///// </summary>
    //PN = 64,

    /// <summary>
    ///     Singapore
    /// </summary>
    SG = 65,

    /// <summary>
    ///     Thailand
    /// </summary>
    TH = 66,

    /// <summary>
    ///     Japan
    /// </summary>
    JP = 81,

    /// <summary>
    ///     South Korea
    /// </summary>
    KR = 82,

    /// <summary>
    ///     Vietnam
    /// </summary>
    VN = 84,

    /// <summary>
    ///     China
    /// </summary>
    CN = 86,

    /// <summary>
    ///     Turkey
    /// </summary>
    TR = 90,

    /// <summary>
    ///     India
    /// </summary>
    IN = 91,

    /// <summary>
    ///     Pakistan
    /// </summary>
    PK = 92,

    /// <summary>
    ///     Afghanistan
    /// </summary>
    AF = 93,

    /// <summary>
    ///     Sri Lanka
    /// </summary>
    LK = 94,

    /// <summary>
    ///     Myanmar
    /// </summary>
    MM = 95,

    /// <summary>
    ///     Iran
    /// </summary>
    IR = 98,

    /// <summary>
    ///     South Sudan
    /// </summary>
    SS = 211,

    /// <summary>
    ///     Morocco
    /// </summary>
    MA = 212,

    ///// <summary>
    /////     Western Sahara
    ///// </summary>
    //EH = 212,

    /// <summary>
    ///     Algeria
    /// </summary>
    DZ = 213,

    /// <summary>
    ///     Tunisia
    /// </summary>
    TN = 216,

    /// <summary>
    ///     Libya
    /// </summary>
    LY = 218,

    /// <summary>
    ///     Gambia
    /// </summary>
    GM = 220,

    /// <summary>
    ///     Senegal
    /// </summary>
    SN = 221,

    /// <summary>
    ///     Mauritania
    /// </summary>
    MR = 222,

    /// <summary>
    ///     Mali
    /// </summary>
    ML = 223,

    /// <summary>
    ///     Guinea
    /// </summary>
    GN = 224,

    /// <summary>
    ///     Ivory Coast
    /// </summary>
    CI = 225,

    /// <summary>
    ///     Burkina Faso
    /// </summary>
    BF = 226,

    /// <summary>
    ///     Niger
    /// </summary>
    NE = 227,

    /// <summary>
    ///     Togo
    /// </summary>
    TG = 228,

    /// <summary>
    ///     Benin
    /// </summary>
    BJ = 229,

    /// <summary>
    ///     Mauritius
    /// </summary>
    MU = 230,

    /// <summary>
    ///     Liberia
    /// </summary>
    LR = 231,

    /// <summary>
    ///     Sierra Leone
    /// </summary>
    SL = 232,

    /// <summary>
    ///     Ghana
    /// </summary>
    GH = 233,

    /// <summary>
    ///     Nigeria
    /// </summary>
    NG = 234,

    /// <summary>
    ///     Chad
    /// </summary>
    TD = 235,

    /// <summary>
    ///     Central African Republic
    /// </summary>
    CF = 236,

    /// <summary>
    ///     Cameroon
    /// </summary>
    CM = 237,

    /// <summary>
    ///     Cape Verde
    /// </summary>
    CV = 238,

    /// <summary>
    ///     Sao Tome and Principe
    /// </summary>
    ST = 239,

    /// <summary>
    ///     Equatorial Guinea
    /// </summary>
    GQ = 240,

    /// <summary>
    ///     Gabon
    /// </summary>
    GA = 241,

    /// <summary>
    ///     Republic of the Congo
    /// </summary>
    CG = 242,

    /// <summary>
    ///     Democratic Republic of the Congo
    /// </summary>
    CD = 243,

    /// <summary>
    ///     Angola
    /// </summary>
    AO = 244,

    /// <summary>
    ///     GuineaBissau
    /// </summary>
    GW = 245,

    /// <summary>
    ///     British Indian Ocean Territory
    /// </summary>
    IO = 246,

    /// <summary>
    ///     Seychelles
    /// </summary>
    SC = 248,

    /// <summary>
    ///     Sudan
    /// </summary>
    SD = 249,

    /// <summary>
    ///     Rwanda
    /// </summary>
    RW = 250,

    /// <summary>
    ///     Ethiopia
    /// </summary>
    ET = 251,

    /// <summary>
    ///     Somalia
    /// </summary>
    SO = 252,

    /// <summary>
    ///     Djibouti
    /// </summary>
    DJ = 253,

    /// <summary>
    ///     Kenya
    /// </summary>
    KE = 254,

    /// <summary>
    ///     Tanzania
    /// </summary>
    TZ = 255,

    /// <summary>
    ///     Uganda
    /// </summary>
    UG = 256,

    /// <summary>
    ///     Burundi
    /// </summary>
    BI = 257,

    /// <summary>
    ///     Mozambique
    /// </summary>
    MZ = 258,

    /// <summary>
    ///     Zambia
    /// </summary>
    ZM = 260,

    /// <summary>
    ///     Madagascar
    /// </summary>
    MG = 261,

    /// <summary>
    ///     Mayotte
    /// </summary>
    YT = 262,

    ///// <summary>
    /////     Reunion
    ///// </summary>
    //RE = 262,

    /// <summary>
    ///     Zimbabwe
    /// </summary>
    ZW = 263,

    /// <summary>
    ///     Namibia
    /// </summary>
    NA = 264,

    /// <summary>
    ///     Malawi
    /// </summary>
    MW = 265,

    /// <summary>
    ///     Lesotho
    /// </summary>
    LS = 266,

    /// <summary>
    ///     Botswana
    /// </summary>
    BW = 267,

    /// <summary>
    ///     Swaziland
    /// </summary>
    SZ = 268,

    /// <summary>
    ///     Comoros
    /// </summary>
    KM = 269,

    /// <summary>
    ///     Saint Helena
    /// </summary>
    SH = 290,

    /// <summary>
    ///     Eritrea
    /// </summary>
    ER = 291,

    /// <summary>
    ///     Aruba
    /// </summary>
    AW = 297,

    /// <summary>
    ///     Faroe Islands
    /// </summary>
    FO = 298,

    /// <summary>
    ///     Greenland
    /// </summary>
    GL = 299,

    /// <summary>
    ///     Gibraltar
    /// </summary>
    GI = 350,

    /// <summary>
    ///     Portugal
    /// </summary>
    PT = 351,

    /// <summary>
    ///     Luxembourg
    /// </summary>
    LU = 352,

    /// <summary>
    ///     Ireland
    /// </summary>
    IE = 353,

    /// <summary>
    ///     Iceland
    /// </summary>
    IS = 354,

    /// <summary>
    ///     Albania
    /// </summary>
    AL = 355,

    /// <summary>
    ///     Malta
    /// </summary>
    MT = 356,

    /// <summary>
    ///     Cyprus
    /// </summary>
    CY = 357,

    /// <summary>
    ///     Finland
    /// </summary>
    FI = 358,

    /// <summary>
    ///     Bulgaria
    /// </summary>
    BG = 359,

    /// <summary>
    ///     Lithuania
    /// </summary>
    LT = 370,

    /// <summary>
    ///     Latvia
    /// </summary>
    LV = 371,

    /// <summary>
    ///     Estonia
    /// </summary>
    EE = 372,

    /// <summary>
    ///     Moldova
    /// </summary>
    MD = 373,

    /// <summary>
    ///     Armenia
    /// </summary>
    AM = 374,

    /// <summary>
    ///     Belarus
    /// </summary>
    BY = 375,

    /// <summary>
    ///     Andorra
    /// </summary>
    AD = 376,

    /// <summary>
    ///     Monaco
    /// </summary>
    MC = 377,

    /// <summary>
    ///     San Marino
    /// </summary>
    SM = 378,

    /// <summary>
    ///     Vatican
    /// </summary>
    VA = 379,

    /// <summary>
    ///     Ukraine
    /// </summary>
    UA = 380,

    /// <summary>
    ///     Serbia
    /// </summary>
    RS = 381,

    /// <summary>
    ///     Montenegro
    /// </summary>
    ME = 382,

    /// <summary>
    ///     Kosovo
    /// </summary>
    XK = 383,

    /// <summary>
    ///     Croatia
    /// </summary>
    HR = 385,

    /// <summary>
    ///     Slovenia
    /// </summary>
    SI = 386,

    /// <summary>
    ///     Bosnia and Herzegovina
    /// </summary>
    BA = 387,

    /// <summary>
    ///     Macedonia
    /// </summary>
    MK = 389,

    /// <summary>
    ///     Czech Republic
    /// </summary>
    CZ = 420,

    /// <summary>
    ///     Slovakia
    /// </summary>
    SK = 421,

    /// <summary>
    ///     Liechtenstein
    /// </summary>
    LI = 423,

    /// <summary>
    ///     Falkland Islands
    /// </summary>
    FK = 500,

    /// <summary>
    ///     Belize
    /// </summary>
    BZ = 501,

    /// <summary>
    ///     Guatemala
    /// </summary>
    GT = 502,

    /// <summary>
    ///     El Salvador
    /// </summary>
    SV = 503,

    /// <summary>
    ///     Honduras
    /// </summary>
    HN = 504,

    /// <summary>
    ///     Nicaragua
    /// </summary>
    NI = 505,

    /// <summary>
    ///     Costa Rica
    /// </summary>
    CR = 506,

    /// <summary>
    ///     Panama
    /// </summary>
    PA = 507,

    /// <summary>
    ///     Saint Pierre and Miquelon
    /// </summary>
    PM = 508,

    /// <summary>
    ///     Haiti
    /// </summary>
    HT = 509,

    /// <summary>
    ///     Saint Barthelemy
    /// </summary>
    BL = 590,

    ///// <summary>
    /////     Saint Martin
    ///// </summary>
    //MF = 590,

    /// <summary>
    ///     Bolivia
    /// </summary>
    BO = 591,

    /// <summary>
    ///     Guyana
    /// </summary>
    GY = 592,

    /// <summary>
    ///     Ecuador
    /// </summary>
    EC = 593,

    /// <summary>
    ///     Paraguay
    /// </summary>
    PY = 595,

    /// <summary>
    ///     Suriname
    /// </summary>
    SR = 597,

    /// <summary>
    ///     Uruguay
    /// </summary>
    UY = 598,

    /// <summary>
    ///     Curacao
    /// </summary>
    CW = 599,

    ///// <summary>
    /////     Netherlands Antilles
    ///// </summary>
    //AN = 599,

    /// <summary>
    ///     East Timor
    /// </summary>
    TL = 670,

    /// <summary>
    ///     Antarctica
    /// </summary>
    AQ = 672,

    /// <summary>
    ///     Brunei
    /// </summary>
    BN = 673,

    /// <summary>
    ///     Nauru
    /// </summary>
    NR = 674,

    /// <summary>
    ///     Papua New Guinea
    /// </summary>
    PG = 675,

    /// <summary>
    ///     Tonga
    /// </summary>
    TO = 676,

    /// <summary>
    ///     Solomon Islands
    /// </summary>
    SB = 677,

    /// <summary>
    ///     Vanuatu
    /// </summary>
    VU = 678,

    /// <summary>
    ///     Fiji
    /// </summary>
    FJ = 679,

    /// <summary>
    ///     Palau
    /// </summary>
    PW = 680,

    /// <summary>
    ///     Wallis and Futuna
    /// </summary>
    WF = 681,

    /// <summary>
    ///     Cook Islands
    /// </summary>
    CK = 682,

    /// <summary>
    ///     Niue
    /// </summary>
    NU = 683,

    /// <summary>
    ///     Samoa
    /// </summary>
    WS = 685,

    /// <summary>
    ///     Kiribati
    /// </summary>
    KI = 686,

    /// <summary>
    ///     New Caledonia
    /// </summary>
    NC = 687,

    /// <summary>
    ///     Tuvalu
    /// </summary>
    TV = 688,

    /// <summary>
    ///     French Polynesia
    /// </summary>
    PF = 689,

    /// <summary>
    ///     Tokelau
    /// </summary>
    TK = 690,

    /// <summary>
    ///     Micronesia
    /// </summary>
    FM = 691,

    /// <summary>
    ///     Marshall Islands
    /// </summary>
    MH = 692,

    /// <summary>
    ///     Russia
    /// </summary>
    RU = 7,

    ///// <summary>
    /////     Kazakhstan
    ///// </summary>
    //KZ = 7,

    /// <summary>
    ///     North Korea
    /// </summary>
    KP = 850,

    /// <summary>
    ///     Hong Kong
    /// </summary>
    HK = 852,

    /// <summary>
    ///     Macau
    /// </summary>
    MO = 853,

    /// <summary>
    ///     Cambodia
    /// </summary>
    KH = 855,

    /// <summary>
    ///     Laos
    /// </summary>
    LA = 856,

    /// <summary>
    ///     Bangladesh
    /// </summary>
    BD = 880,

    /// <summary>
    ///     Taiwan
    /// </summary>
    TW = 886,

    /// <summary>
    ///     Maldives
    /// </summary>
    MV = 960,

    /// <summary>
    ///     Lebanon
    /// </summary>
    LB = 961,

    /// <summary>
    ///     Jordan
    /// </summary>
    JO = 962,

    /// <summary>
    ///     Syria
    /// </summary>
    SY = 963,

    /// <summary>
    ///     Iraq
    /// </summary>
    IQ = 964,

    /// <summary>
    ///     Kuwait
    /// </summary>
    KW = 965,

    /// <summary>
    ///     Saudi Arabia
    /// </summary>
    SA = 966,

    /// <summary>
    ///     Yemen
    /// </summary>
    YE = 967,

    /// <summary>
    ///     Oman
    /// </summary>
    OM = 968,

    /// <summary>
    ///     Palestine
    /// </summary>
    PS = 970,

    /// <summary>
    ///     United Arab Emirates
    /// </summary>
    AE = 971,

    /// <summary>
    ///     Israel
    /// </summary>
    IL = 972,

    /// <summary>
    ///     Bahrain
    /// </summary>
    BH = 973,

    /// <summary>
    ///     Qatar
    /// </summary>
    QA = 974,

    /// <summary>
    ///     Bhutan
    /// </summary>
    BT = 975,

    /// <summary>
    ///     Mongolia
    /// </summary>
    MN = 976,

    /// <summary>
    ///     Nepal
    /// </summary>
    NP = 977,

    /// <summary>
    ///     Tajikistan
    /// </summary>
    TJ = 992,

    /// <summary>
    ///     Turkmenistan
    /// </summary>
    TM = 993,

    /// <summary>
    ///     Azerbaijan
    /// </summary>
    AZ = 994,

    /// <summary>
    ///     Georgia
    /// </summary>
    GE = 995,

    /// <summary>
    ///     Kyrgyzstan
    /// </summary>
    KG = 996,

    /// <summary>
    ///     Uzbekistan
    /// </summary>
    UZ = 998,

    /// <summary>
    ///     Guernsey
    /// </summary>
    GG = 441481,

    /// <summary>
    ///     Jersey
    /// </summary>
    JE = 441534,

    /// <summary>
    ///     Isle of Man
    /// </summary>
    IM = 441624,


    ///// <summary>
    /////     Unknown
    ///// </summary>
    //None = 1000000,

    /// <summary>
    ///     Can Call All
    /// </summary>
    All = 1000001


}
