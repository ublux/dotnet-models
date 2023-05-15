namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Mp3 or Wav audio file. Previously called Audio Greeting
/// </summary>
public partial class Audio : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties    

    #region Subdocuments

    /// <summary>
    ///     Audio in mp3 format
    /// </summary>
    [AllowUpdate(false)]    
    [SwaggerSchema(ReadOnly = true)]
    public StoredFile? AudioMp3 { get; set; }

    /// <summary>
    ///     Audio in wav format
    /// </summary>
    [AllowUpdate(false)]    
    [SwaggerSchema(ReadOnly = true)]
    public required StoredFile? AudioWav { get; set; }

    #endregion

    /// <summary>
    ///     Name of audio
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Duration of audio in seconds
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [HideForCreateRequest]
    public required double DurationInSeconds { get; set; }

    /// <summary>
    ///     Description of audio
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(1000)]
    public string? Description { get; set; }

    #endregion

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;
    }

    #endregion
}
