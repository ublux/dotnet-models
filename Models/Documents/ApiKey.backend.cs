#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary>
[DebuggerDisplay("Id:{Id} IdAccount:{IdAccount}")]
public partial class ApiKey 
{    
    /// <summary>
    ///     Generate random api key
    /// </summary>
    public static string GenerateRandmKey() => $"K{RunningApplicationInstance.ToBase62(BitConverter.ToUInt64(Guid.NewGuid().ToByteArray()))}{RunningApplicationInstance.ToBase62(BitConverter.ToUInt64(Guid.NewGuid().ToByteArray()))}";
}

#endif