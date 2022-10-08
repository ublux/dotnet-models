namespace Ublux.Communications.Models;

/// <summary>
///     Neede to know who transfered the call
/// </summary>
public interface IAttendantTransfer
{
    /// <summary> Id of call that attendant transfered this call </summary>
    [IsUbluxRequired]
    string IdCallAttendantTransfer { get; set; }
}
