using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using Exception = System.Exception;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Transcription Cloud service
/// </summary>
public partial class CloudServiceTranscription : CloudService
{
    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType
    {
        get => CloudServiceType.TS;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Date when received last request
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [HideForCreateRequest]
    public DateTime DateAlive { get; set; }
    
    /// <summary>
    ///     Get url needed to get info about transcription service. Note an authorization will be also needed
    /// </summary>
    public string GetInfoUrl() => $"https://{this.ExternalIp}:{Constants.TranscriptionServicePort}";

    /// <summary>
    ///     Get info about transcription services. All requests will be sent in parallel
    /// </summary>
    [UsedImplicitly]
    public static async IAsyncEnumerable<KeyValuePair<CloudServiceTranscription,TranscriptionServiceMemoryInfo>> GetServicesInfo(
        IEnumerable<CloudServiceTranscription> services,
        HttpClient httpClientThatAllowsInsecureConnections,
        ILogger logger,
        [EnumeratorCancellation] CancellationToken token
    )
    {
        // create all request so that they start executing all of them at the same time async
        var tasks = services.Select(
            ts => GetServiceInfo(ts, httpClientThatAllowsInsecureConnections, logger, token)
        ).ToList();

        foreach (var t in tasks.TakeWhile(_ => !token.IsCancellationRequested))
        {
            var info = await t;
            if (info.HasValue)
                yield return info.Value;
        }
    }

    /// <summary>
    ///     Get information about a transcription service such as how many jobs its currently running
    /// </summary>
    public static async Task<KeyValuePair<CloudServiceTranscription, TranscriptionServiceMemoryInfo>?> GetServiceInfo(
        CloudServiceTranscription ts,
        HttpClient httpClientThatAllowsInsecureConnections,
        ILogger logger,
        CancellationToken token
    )
    {
        var url = ts.GetInfoUrl();
        
        // request should not take longer than 2 seconds
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(3));

        try
        {
            if (token == CancellationToken.None)
            {
                token = cts.Token;
            }
            else
            {
                using var tmp = CancellationTokenSource.CreateLinkedTokenSource(token, cts.Token);
                token = tmp.Token;
            }

            using var response = await httpClientThatAllowsInsecureConnections.GetAsync(url, token);
            response.EnsureSuccessStatusCode();

            using var content = response.Content;

            // should contain a token that will be used to retrieve transcription latter
            var result = await content.ReadAsStringAsync(token);

            var info = TranscriptionServiceMemoryInfo.FromJson(result);

            if (info is null)
                throw new Exception("Unable to deserialize transcription service info");

            return new KeyValuePair<CloudServiceTranscription, TranscriptionServiceMemoryInfo>(ts, info);
        }
        catch (Exception ex)
        {
            if (token.IsCancellationRequested == false)
            {
                logger.Log(LogLevel.Error, 478394858, "Could not get transcription service info from {url}. {ex}", url, ex);
            }
        }

        await cts.CancelAsync();
        return null;
    }
}