namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Tokens that are not authorized. Perhaps a token has been stolen
/// </summary>
public partial class UnauthorizedToken : UbluxDocument, IReferencesTags
{
    // id is the last 16 characters of JWT

    /// <summary>
    ///     Full token
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string Jwt { get; set; }

    /// <summary>
    ///     Id user
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Identity))]
    [IsUbluxRequired]
    public required string IdIdentity { get; set; }

    /// <summary>
    ///     Date when JWT expires
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required DateTime ExpirationDate { get; set; }

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> IdsTags { get; set; } = new();
}
