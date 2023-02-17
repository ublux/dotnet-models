﻿namespace Ublux.Communications.Models.Documents;

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
    public List<ContactNumber> ContactNumbers { get; set; } = new();

    /// <summary>
    ///     Email addresses of contact
    /// </summary>
    [AllowUpdate(true)]
    public List<ContactEmail> ContactEmails { get; set; } = new();

    /// <summary>
    ///     Mailing Addresses of contact
    /// </summary>
    [AllowUpdate(true)]
    public List<MailingAddress> MailingAddresses { get; set; } = new();

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

    ///// <summary>
    /////     Used to know if contact changed or not. Contacts service is responsible (Julio) for generating this hash
    ///// </summary>
    //[AllowUpdate(false)]
    //// [IsUbluxRequired]
    //[HideForCreateRequest]
    //public string? Hash { get; set; }

    /// <summary>
    ///     Contact Notes
    /// </summary>
    [AllowUpdate(true)]
    public string? Notes { get; set; }

    /// <summary>
    ///     Customer custom data
    /// </summary>
    [AllowUpdate(true)]
    public List<Variable> Variables { get; set; } = new();

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
}