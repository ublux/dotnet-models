﻿namespace Ublux.Communications.Models.Documents;

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
    [IsUbluxRequired]
    public required string FriendlyName { get; set; }

    /// <summary>
    ///     Duration of audio in seconds
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    public required double DurationInSeconds { get; set; }

    /// <summary>
    ///     Description of audio
    /// </summary>
    [AllowUpdate(true)]
    public string? Description { get; set; }

    #endregion
}
