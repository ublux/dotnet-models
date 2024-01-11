// ReSharper disable CheckNamespace
namespace Ublux.Communications.Enums;

/// <summary>
///     Type of cloud service
/// </summary>
public enum CloudServiceType
{
    /// <summary>
    ///     No type
    /// </summary>
    None,

    /// <summary>
    ///     PBX
    /// </summary>
    PBX,
    
    /// <summary>
    ///     Web service
    /// </summary>
    API,
    
    /// <summary>
    ///     Web hosting
    /// </summary>
    WH,
    
    /// <summary>
    /// Web app
    /// </summary>
    WA,
    
    /// <summary>
    ///     Transcription Service
    /// </summary>
    TS
}
