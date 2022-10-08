namespace Ublux.Communications.Models;

/// <summary>
///     Customizable settings of an account
/// </summary>
public class AccountSettings
{
    /// <summary>
    ///     When creating a new line for this account what option do we assign to RecordExternalCalls?
    /// </summary>
    public bool TurnOnRecordingOfExternalCallsWhenCreatingLine { get; set; }

    /// <summary>
    ///     When creating a new line for this account what option do we assign to RecordInternalCalls?
    /// </summary>
    public bool TurnOnRecordingOfInternalCallsWhenCreatingLine { get; set; }

    /// <summary>
    ///     Example: Antonio Namnum (Ublux)
    /// </summary>
    [IsUbluxRequired]
    public string ContactCallerIdTemplate { get; set; } = "{FullName} ({Company})";

}
