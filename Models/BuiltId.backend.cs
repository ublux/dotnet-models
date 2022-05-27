#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     Created to ensure all ids are built correctly
/// </summary>
public struct BuiltId
{
    /// <summary>
    ///     Entity id
    /// </summary>
    public string Id { get; private set; }

    /// <summary>
    ///     Constructor
    /// </summary>
    internal BuiltId(string id)
    {
        Id = id;
    }

    /// <summary>
    ///     Thanks to this method AutoFixture can generate random objects needed for unit tests
    /// </summary>
    [Obsolete("Needed for AutoFixture. Without this no dummy objects could be generated")]
    public BuiltId(DateTime doNotCallThisMethod)
    {
        this.Id = doNotCallThisMethod.Ticks.ToString();
    }
}

#endif