using System.Collections.Concurrent;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Call made to an extension
/// </summary>
[BsonIgnoreExtraElements]
public partial class CallOutgoingToExtension : CallOutgoing, ICallToExtension
{
    #region Properties

    #region References  

    /// <summary>
    ///     Extension being called
    /// </summary>
    [References(typeof(Extension))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? IdExtension { get; set; }

    /// <summary>
    ///     Phone that answered
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    public string? IdPhoneThatAnswered { get; set; }

    /// <summary>
    ///     Phones that ring
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    public ConcurrentBag<string> IdsPhonesThatRing { get; set; } = [];

    /// <summary>
    ///     Phones that did not ring
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    public ConcurrentBag<string> IdsPhonesThatDidNotRing { get; set; } = [];

    #endregion

    #endregion

    /// <summary>
    ///     Override because when calling an extension we are not calling any country.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    // [UbluxValidationNotRequired] // Value can be None
    public override required CountryIsoCode ToCountry { get; set; }

    /// <summary>
    ///     Override because when calling an extension we are not using any country
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    // [UbluxValidationNotRequired] // Value can be None
    public override required CountryIsoCode FromCountry { get; set; }

    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public override CallType CallType
    {
        get => CallType.OutgoingToExtension;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}

