﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Group of line keys
/// </summary>
public partial class SpeedDialGroup : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region Subdocuments

    /// <summary>
    ///     Group of speed dial keys. Must have at least one
    /// </summary>
    [AllowUpdate(true)]    
    public List<SpeedDial> SpeedDials { get; set; } = [];

    #endregion

    /// <summary>
    ///     Friendly name of line key group
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Description of line key group
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(1000)]
    public string? Description { get; set; } = string.Empty;

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
