namespace Ublux.Communications.Models;

/// <summary>
///     Account secrets
/// </summary>
public class AccountSecrets
{
    ///// <summary>
    /////     7 pin random code used to link an email with
    /////     {RandCode}
    /////     EAB24
    ///// </summary>
    //[AllowUpdate(false)]
    //[IsRequired]
    //public string PinFax { get; set; } = string.Empty;

    /// <summary>
    ///     9 digit number that a customer must dial in order to link his phone to a new account. 
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string PinPhone { get; set; } = string.Empty;

    /// <summary>
    ///     If you dial *7 and you enter this pin you will be able to ChanSpy "spy" on a extension
    ///     9 digits now to make it more secure
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string PinSpy { get; set; } = string.Empty;




}
