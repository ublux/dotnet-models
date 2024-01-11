namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Contact
/// </summary>
public partial class Contact : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     If null it can be seen by entire account. In other words it is a global contact. 
    ///     Otherwise it will only be visible to a specific user (user)
    ///     
    ///     Who owns the contact. If null it will belong to entire account
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(User))]
    public string? IdUserOwner { get; set; }    

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Phone numbers of contact
    ///     Key = phone number
    ///     Value = type (example = work)
    /// </summary>
    [AllowUpdate(true)]
    public List<ContactNumber> ContactNumbers { get; set; } = [];

    /// <summary>
    ///     Email addresses of contact
    /// </summary>
    [AllowUpdate(true)]
    public List<ContactEmail> ContactEmails { get; set; } = [];

    /// <summary>
    ///     Mailing Addresses of contact
    /// </summary>
    [AllowUpdate(true)]
    public List<MailingAddress> MailingAddresses { get; set; } = [];

    #endregion

    ///// <summary>
    /////     Who owns the contact. If null it will belong to entire account
    ///// </summary>
    //[AllowUpdate(true)]
    //public string? Owner { get; set; }

    /// <summary>
    ///     Contact first name
    /// </summary>
    [AllowUpdate(true)]    
    public string? FirstName { get; set; }

    /// <summary>
    ///     Contact last name
    /// </summary>
    [AllowUpdate(true)]
    public string? LastName { get; set; }

    /// <summary>
    ///     Contact job tittle
    /// </summary>
    [AllowUpdate(true)]
    public string? JobTitle { get; set; }

    /// <summary>
    /// </summary>
    [AllowUpdate(true)]
    public string? Company { get; set; }

    /// <summary>
    ///     Contact Notes
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(4000)]
    public string? Notes { get; set; }

    /// <summary>
    ///     Customer custom data
    /// </summary>
    [AllowUpdate(true)]
    public List<Variable> Variables { get; set; } = [];

    #endregion

    #region Helper methods

    /// <summary>
    ///     Get full name of contact
    /// </summary>
    public string GetFullName()
    {
        StringBuilder sb = new(64);

        if (!string.IsNullOrEmpty(FirstName))
        {
            sb.Append(FirstName);
        }

        if (!string.IsNullOrEmpty(LastName))
        {
            if (sb.Length > 0)
                sb.Append(' ');
            sb.Append(LastName);
        }

        return sb.ToString();
    }

    ///// <summary>
    /////     Compute hash of contacts. Needed so that we can sync them
    ///// </summary>
    //public string GetHash()
    //{
    //    var val = string.Join(null, GetValuesNeededToHash());
    //    var bytes = Encoding.UTF8.GetBytes(val);
    //    var hash = xxHash64.ComputeHash(bytes) >> 22;
    //    return RunningApplicationInstance.ToBase62(hash);
    //}
    //IEnumerable<string> GetValuesNeededToHash()
    //{
    //    if (FirstName != null)
    //        yield return FirstName;
    //    if (LastName != null)
    //        yield return LastName;
    //    if (JobTitle != null)
    //        yield return JobTitle;
    //    if (Company != null)
    //        yield return Company;
    //    if (Notes != null)
    //        yield return Notes;
    //    foreach (var cn in ContactNumbers)
    //    {
    //        if (cn.NumberInternationalFormat is not null)
    //            yield return cn.NumberInternationalFormat;

    //        yield return cn.Label.ToString();
    //    }

    //    foreach (var ce in ContactEmails)
    //    {
    //        if (ce.Email is not null)
    //            yield return ce.Email;

    //        yield return ce.Label.ToString();
    //    }
    //}

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

        // enable searching fast by IdContactOwner
        yield return new MongoDbIndex(collection, nameof(IdUserOwner))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));

        // enable searching fast by contact phone number search index
        yield return new MongoDbIndex(collection, nameof(ContactNumbers), nameof(ContactNumber.SearchIndex))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));  
        
        // enable searching fast by contact phone number search index
        yield return new MongoDbIndex(collection, nameof(ContactEmails), nameof(ContactEmail.SearchIndex))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated)); 
    }

    #endregion
}