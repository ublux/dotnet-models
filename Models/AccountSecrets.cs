namespace Ublux.Communications.Domain.Models;

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
    //[Required]
    //public string PinFax { get; set; } = string.Empty;

    /// <summary>
    ///     7 digit number that a customer must dial in order to link his phone to a new account. 
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    public string PinPhone { get; set; } = string.Empty;

    /// <summary>
    ///     If you dial *7 and you enter this pin you will be able to ChanSpy "spy" on a extension
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    public string PinSpy { get; set; } = string.Empty;

    /// <summary>
    ///     Validate account secrets
    /// </summary>
    /// <returns></returns>
    public IEnumerable<ValidationError> Validate()
    {
        if (PinPhone.Length != 7 || PinPhone.Any(x => char.IsDigit(x) == false))
            yield return new ValidationError()
            {
                ErrorMessage = "AccountSecrets pin phone must be 7 characters long and only contain digits",
                PropertyName = nameof(PinPhone),
                PropertyValue = PinPhone
            };


        if (PinSpy.Length != 7 || PinSpy.Any(x => char.IsDigit(x) == false))
            yield return new ValidationError()
            {
                ErrorMessage = "AccountSecrets pin spy must be 7 characters long and only contain digits",
                PropertyName = nameof(PinSpy),
                PropertyValue = PinSpy
            };
    }


}
