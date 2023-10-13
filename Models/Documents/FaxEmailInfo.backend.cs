//#if UBLUX_BACKEND

//namespace Ublux.Communications.Models.Documents;

///// <summary>
/////     Ublux sends and receives faxes via email. This class enables to know the relationship between an email and a fax.
/////     For example email foo@gmail.com will send faxes through VoipFax with id XXXX-XXXX
///// </summary>
//public partial class FaxEmailInfo : UbluxDocument, IReferencesAccount
//{
//    // id is the email address in lowercase

//    #region References



//    #endregion

//    /// <summary>
//    ///     It is a 4 digit random code that the user must call in his Ublux phone in order to identify his user.
//    ///     The code the user dials will start with *9 followed by this 4 digit number
//    /// </summary>
//    [AllowUpdate(false)] 
//    [SwaggerSchema(ReadOnly = true)] 
//    [IgnoreDataMember]
//    [IsUbluxRequired]
//    public required int IdentificationToken { get; set; }

//    /// <summary>
//    ///     Needed because identification token expires. IdentificationToken should be valid for 5 minutes
//    /// </summary>
//    [AllowUpdate(false)] 
//    [SwaggerSchema(ReadOnly = true)] 
//    [IgnoreDataMember]
//    [IsUbluxRequired]
//    public required DateTime DateIdentificationTokenCreated { get; set; }

//    /// <summary>
//    ///     If someone sends a lot of emails without reading the instructions it will be marked as spam
//    /// </summary>
//    [AllowUpdate(false)] 
//    [SwaggerSchema(ReadOnly = true)] 
//    [IgnoreDataMember]
//    public bool IsSpam { get; set; }

//    /// <summary>
//    ///     The first time the user sends a fax we explain that he has to wait for a confirmation
//    /// </summary>
//    [AllowUpdate(false)] 
//    [SwaggerSchema(ReadOnly = true)] 
//    [IgnoreDataMember]
//    public bool HaveWeSentEmailExplainingUserHasToWaitForConfirmation { get; set; }
//}

//#endif