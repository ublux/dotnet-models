namespace Ublux.Communications.Domain.Models.SubDocuments;

/// <summary>
///     Contact email address
/// </summary>
public class ContactEmail
{
    ///// <summary>
    ///// id is id of account followed by email
    ///// </summary>
    //[Required]
    //public string Id { get; set; } = string.Empty;
    //// todo create index on database

    /// <summary>
    ///     Contact email address
    /// </summary>
    [AllowUpdate(true)]
    [Required]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    ///     Type of email
    /// </summary>
    [AllowUpdate(true)]
    public LabelEmailType Label { get; set; }

    ///// <summary>
    /////     Get id of subdocument
    ///// </summary>
    //public string GetId(string idAccount)
    //{
    //    return $"{idAccount}-{Email?.Replace(" ", "").ToLower()}";
    //}
}
