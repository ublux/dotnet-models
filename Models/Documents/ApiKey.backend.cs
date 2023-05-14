#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary>
[DebuggerDisplay("Id:{Id} IdAccount:{IdAccount}")]
public partial class ApiKey 
{
    private static string GenerateRandomBase62 => RunningApplicationInstance.ToBase62(BitConverter.ToUInt64(Guid.NewGuid().ToByteArray()));

    /// <summary>
    ///     Generate random api key
    /// </summary>
    public static string GenerateRandmKey() => $"K{GenerateRandomBase62}{GenerateRandomBase62}";
}

#endif