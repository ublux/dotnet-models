namespace Ublux.Communications.Models;

/// <summary>
///     Contact email address
/// </summary>
public partial class ContactEmail
{            
    /// <summary>
    ///     Contact email address
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    ///     Type of email
    /// </summary>
    [AllowUpdate(true)]
    public LabelEmailType Label { get; set; }
}
