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
    [IsUbluxRequired]
    public required string Email { get; set; }

    /// <summary>
    ///     Type of email
    /// </summary>
    [AllowUpdate(true)]
    public LabelEmailType Label { get; set; }
}
