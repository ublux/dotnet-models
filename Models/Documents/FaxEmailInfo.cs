//namespace Ublux.Communications.Models.Documents;

///// <summary>
/////     Ublux sends and receives faxes via email. This class enables to know the relationship between an email and a fax.
/////     For example email foo@gmail.com will send faxes through VoipFax with id XXXX-XXXX
///// </summary>
//public partial class FaxEmailInfo : UbluxDocument, IReferencesTags
//{
//    #region Properties

//    /// <summary>
//    ///     Email address. This should not be part of Email table
//    /// </summary>
//    // [References(typeof(Email))]
//    [AllowUpdate(false)]
//    [SwaggerSchema(ReadOnly = true)]
//    public required string EmailAddress { get; set; } = string.Empty;

//    #region References

//    /// <summary>
//    ///     If email was validated with phone then what line validated this email?
//    ///     Phone that validated email
//    /// </summary>
//    [AllowUpdate(false)] 
//    [SwaggerSchema(ReadOnly = true)] 
//    [References(typeof(Phone))]
//    public Phone? PhoneThatValidatedEmail { get; set; }



//    #endregion

//    /// <summary>
//    ///     Number of emails received
//    /// </summary>
//    [AllowUpdate(false)] 
//    [SwaggerSchema(ReadOnly = true)] 
//    [IsUbluxRequired] /* at least one email should be received */
//    public required int NumberOfEmailsReceived { get; set; }

//    /// <summary>
//    ///     Current status of authenticating email
//    /// </summary>
//    [AllowUpdate(false)] 
//    [SwaggerSchema(ReadOnly = true)] 
//    [IsUbluxRequired]
//    public required LinkFaxToEmailStatus ReplyStatus { get; set; }

//    #endregion

    //#region MongoDB

    ///// <inheritdoc />
    //public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    //{
    //    // this collection
    //    var collection = this.GetType().GetCollectionUsedByType();

    //    // get all mandatory indexes
    //    foreach (var item in base.GetMandatoryIndexes(collection))
    //        yield return item;       
    //}

    //#endregion
//}
