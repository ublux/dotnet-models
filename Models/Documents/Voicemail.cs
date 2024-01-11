namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Extensions may forward an existing voicemail to another extension
/// </summary>
/* Attributes that help with deserialization */
[JsonConverter(typeof(JsonSubtypes), nameof(VoicemailType))]
[JsonSubtypes.KnownSubType(typeof(Voicemail), nameof(VoicemailType.Regular))]
[JsonSubtypes.KnownSubType(typeof(VoicemailForwarded), nameof(VoicemailType.Forwarded))]
[BsonKnownTypes(
    typeof(Voicemail),
    typeof(VoicemailForwarded))]
public partial class Voicemail : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region References   

    /// <summary>
    ///     Ids of lines that can listen to voicemail
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Phone))]
    public List<string> IdsPhonesThatCanListenToVoicemail { get; set; } = [];

    /// <summary>
    ///     Email where voicemail was sent
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [References(typeof(Email))]
    public required string IdEmail { get; set; } = string.Empty;

    #endregion

    /// <summary>
    ///     Type of voicemail
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [HideForCreateRequest]
    public virtual VoicemailType VoicemailType => VoicemailType.Regular;

    /// <summary>
    ///     Voicemail duration in seconds
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required double DurationInSeconds { get; set; }

    /// <summary>
    ///     Voicemail in wav format. Optional because there may be an error
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public StoredFile? VoicemailWav { get; set; }

    /// <summary>
    ///     Voicemail in mp3 format. Optional because there may be an error
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public StoredFile? VoicemailMp3 { get; set; }

    /// <summary>
    ///     If there is an error sending the voicemail then the error description
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    // [UbluxValidationStringRange(1000)]
    public List<string> ErrorMessages { get; set; } = [];
    
    /// <summary>
    ///     Detected transcription language
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(100)]
    public string? TranscriptionLanguage { get; set; }
    
    /// <summary>
    ///     Voicemail converted to text
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    public string? TranscriptionText { get; set; }

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;

        // enable searching fast by id of email
        yield return new MongoDbIndex(collection, nameof(IdEmail))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));

        // enable searching fast by ids lines that can listen to voicemail
        yield return new MongoDbIndex(collection, nameof(IdsPhonesThatCanListenToVoicemail))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));

        // enable searching fast by type of voicemail
        yield return new MongoDbIndex(collection, nameof(VoicemailType))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));
    }

    #endregion
}
