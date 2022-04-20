namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Group used to call multiple parties
/// </summary>
public partial class PowerDialerGroup : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     From what phone number we will make call. 
    /// </summary>
    [References(typeof(VoipNumberPhone))]
        [AllowUpdate(false)]
    public string? IdVoipNumberPhone { get; set; }

    /// <summary>
    ///     Override caller id?
    /// </summary>
    [References(typeof(CallerIdMask))]
        [AllowUpdate(false)]
    public string? IdCallerIdMask { get; set; }

    /// <summary>
    ///     What IVR to execute
    /// </summary>
    [References(typeof(CallFlow))]
        [AllowUpdate(false)]
    public string? IdCallFlow { get; set; }

    /// <summary>
    ///     If on mode simple what extensions will ring to take phone calls
    /// </summary>
        [References(typeof(Extension))]
    [AllowUpdate(false)]
    public string? IdExtension { get; set; }

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Subdocument
    /// </summary>
        [AllowUpdate(false)]
    [Required]
    public List<PowerDialer> PowerDialers
    {
        get => _PowerDialers;
        set { if (value is null) _PowerDialers.Clear(); else _PowerDialers = value; }
    }
    List<PowerDialer> _PowerDialers = new();

    #endregion

    /// <summary>
    ///     Friendly name of power dialer group
    /// </summary>
        [AllowUpdate(true)]
    [Required]
    public string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Description of power dialer group
    /// </summary>
        [AllowUpdate(true)]
    public string? Description { get; set; }

    /// <summary>
    ///     Status of power dialer
    /// </summary>
        [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public PowerDialerGroupStatus PowerDialerGroupStatus  // added for convenience
    {
        get { return (PowerDialerGroupStatus)Interlocked.CompareExchange(ref _powerDialerGroupStatus, 0, 0); }
        set { Interlocked.Exchange(ref _powerDialerGroupStatus, (int)value); }
    }
    int _powerDialerGroupStatus = (int)PowerDialerGroupStatus.ToBeStarted;

    /// <summary>
    ///     If there is an error then what error?
    /// </summary>
        [AllowUpdate(false)]
    [HideForCreateRequest]
    public string? ErrorMessage { get; set; }

    ///// <summary>
    /////     Prevent executing if it exceeds this date range
    ///// </summary>
    //public UbluxTime MaxTimeLimit { get; set; }

    /// <summary>
    ///     Used by pbx to know what is the current item that is executing. Also by web service to let front know what index is being executed.
    /// </summary>
        [AllowUpdate(false)]
    [HideForCreateRequest]
    public int PowerDialerExecutingRecordIndex { get; set; }

    /// <summary>
    ///     If there are 5 agents using the power dialer then there can 5 five concurrent calls.
    ///     When power dialer was first created only one call at a time existed. When that call ended the next call was made.
    /// </summary>
        [AllowUpdate(false)]
    [Required]
    public int NumberOfConcurrentCalls { get; set; }

    #endregion

    #region Helper methods

    /// <summary>
    ///     Is it executing on simple or advance mode
    /// </summary>
    public bool IsSimpleMode()
    {
        return string.IsNullOrEmpty(IdCallFlow);
    }

    #endregion
}
