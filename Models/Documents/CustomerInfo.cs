﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Needed because some providers like the one from Spain require customers info in order to purchase VoipNumber
/// </summary>
public partial class CustomerInfo : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties   

    #region Subdocuments

    /// <summary>
    ///     Address where this phone number is intended to be used
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required MailingAddress MailingAddress { get; set; }

    /// <summary>
    ///     If its a VoipNumber from provider AirNetworks then this information is required
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public AirNetworksCustomerInfo? AirNetworksCustomerInfo { get; set; }

    #endregion

    /// <summary>
    ///     Full legal name
    /// </summary>
    [AllowUpdate(true)]
    public required string FullName { get; set; } = string.Empty;

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

