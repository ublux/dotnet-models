namespace Ublux.Communications.Enums;

/// <summary>
///     In order to send faxes on ublux a user must link his email address to a FaxDID.
///     We use this status meanwhile linking to know the status.
/// </summary>
public enum LinkFaxToEmailStatus
{
    /// <summary>
    ///     Have never replied
    /// </summary>
    None,

    /// <summary>
    ///     Have sent message to user
    /// </summary>
    AskedUserForAccountPin,

    /// <summary>
    ///     When the user validates email and we send instructions on how to use fax
    /// </summary>
    SendWelcomeEmail
}
