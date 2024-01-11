namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Virtual receptionist
/// </summary>
public partial class CallFlowLogic : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties    

    /// <summary>
    ///     Name of virtual receptionist
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Description of virtual receptionist
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(1000)]
    public string? Description { get; set; }

    ///// <summary>
    /////     XML containing the call flow rules
    ///// </summary>
    //[AllowUpdate(true)]
    //[IsUbluxRequired]
    //public required string XmlTree { get; set; } = string.Empty;

    /// <summary>
    ///     XML containing the call flow rules
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required FlowNode Tree { get; set; }

    /// <summary>
    ///     Special bookmarks on tree. This will be separate trees to share common logic
    /// </summary>
    [AllowUpdate(true)]
    public List<NodeBookmark> Bookmarks { get; set; } = [];

    #endregion

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;
    }

    #endregion
}
