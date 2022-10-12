namespace Ublux.Communications.Models;

/// <summary>
///     Power dialer that dials a direct extension and customer
/// </summary>
public class PowerDialerSimple : PowerDialer
{
    /// <summary>
    ///     Id of line that made the phone call if on simple mode
    /// </summary>
    public string? IdLine { get; set; }

    /// <summary>
    ///     Type of power dialer
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public override PowerDialerType PowerDialerType
    {
        get => PowerDialerType.Simple;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

}


