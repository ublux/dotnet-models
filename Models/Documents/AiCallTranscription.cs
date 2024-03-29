﻿namespace Ublux.Communications.Models.Documents;

// SHOULD BE CREATED WHEN CALL IS CREATED!

/// <summary>
///     AI transcription of a phone call. This is the conversion from audio to text only.
/// </summary>
public partial class AiCallTranscription : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region References        

    /// <summary>
    ///     Call being transcribed
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Call))]
    [UbluxValidationRequired]
    public string IdCall { get; set; } = string.Empty;

    #endregion

    /// <summary>
    ///     If there is a language it means there is a transcription
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(50)]
    public string? TranscriptionLanguage { get; set; }

    /// <summary>
    ///     Audio of agent converted to text
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<AiTranscription> Transcription { get; set; } = [];

    ///// <summary>
    /////     If the transcription contains an error. This should be part of main call
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[UbluxValidationStringRange(2000)]
    //[Obsolete]
    //public string? ErrorMessage { get; set; }

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;

        // Enable searching fast by id of call
        yield return new MongoDbIndex(collection, nameof(IdCall));
    }

    #endregion
}