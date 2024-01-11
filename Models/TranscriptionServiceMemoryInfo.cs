using Newtonsoft.Json.Serialization;

namespace Ublux.Communications.Models;

/// <summary>
///     CloudServiceTranscription returns this info
/// </summary>
public class TranscriptionServiceMemoryInfo
{
    /// <summary>
    ///     Convert to json string
    /// </summary>
    public string ToJson()
    {
        // Create a JsonSerializerSettings object with the desired formatting and naming convention
        var settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };
        
        var jsonString = JsonConvert.SerializeObject(this, settings);
        return jsonString;
    }

    /// <summary>
    ///     Create object from json
    /// </summary>
    public static TranscriptionServiceMemoryInfo? FromJson(string json)
    {
        var settings = new JsonSerializerSettings
        {
            // Formatting = Formatting.Indented,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };
        return JsonConvert.DeserializeObject<TranscriptionServiceMemoryInfo>(json, settings);
    }

    /// <summary></summary>
    public required bool ReleaseMode { get; init; } 

    /// <summary></summary>
    public required int WorkRunningCount { get; init; } 

    /// <summary></summary>
    public required int WorkCompleteCount { get; init; } 

    /// <summary></summary>
    public required IEnumerable<string> AllowedClients { get; init; } 

    /// <summary></summary>
    public required IEnumerable<string> WorkRunningIds { get; init; } 

    /// <summary></summary>
    public required IEnumerable<string> WorkCompleteIds { get; init; } 

    /// <summary></summary>
    public required long JobsCreatedCount { get; init; } 

    /// <summary></summary>
    public required bool IsBusy { get; init; } 
}