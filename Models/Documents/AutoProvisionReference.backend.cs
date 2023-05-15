#if UBLUX_BACKEND

using System.Security.Cryptography;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Id is the mac address of a phone. It should point to an ip phone
/// </summary>
public partial class AutoProvisionReference : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     Id of phone that this mac is associated with
    ///     (Note: phone may be deleted and do not exist!)
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Phone))]
    [UbluxValidationRequired]
    public required string IdPhone { get; set; } = string.Empty;

    /// <summary>
    ///     Ip address where it was autoprovisioned
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string Ip { get; set; } = string.Empty;

    /// <summary>
    ///     Ip address where it was autoprovisioned
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string UserAgent { get; set; } = string.Empty;

    #endregion

    ///// <summary>
    /////     When phone calls *54 we will set this to true. We need phone to stay connected so that we can send auto-provision
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //public bool RequestedDisconnect { get; set; }

    ///// <summary>
    /////     We need this to send autoprovision encrypted to phone. Example: y5b0K3z0h3Kw0h03
    /////     Even though we send it through https a hacker can send us a request with the phones mac address and we will send the password.
    /////     
    /////     On yealink phones this is the configuration needed:
    /////     static.auto_provision.aes_key.com
    /////     static.auto_provision.aes_key.mac
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[IgnoreDataMember]
    //public string? CommonAesKey { get; set; }

    /// <summary>
    ///     Password of the phone. We will send the password to the phone only the first time if we have an autoprovision pin.
    ///     To avoid having to require an autoprovision pin this password should be the same allways per phyisical phone. 
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public required string Password { get; set; } = "";

    /// <summary>
    ///     This is the password needed to enter the yealink phone in order to make manual modifications. Our goal is to never have to enter.
    ///     security.user_password
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public string? AdminPassword { get; set; }

    /// <summary>
    ///     Phone was autoprovisioned by whom? This is the session that gave permission to the phone to autoprovision.
    ///     The phone makes autoprovision with a pin. With the pin we retrive the session of the user that had that pin.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(User))]
    public string? IdUserThatAllowedAutoprovision { get; set; }

    #endregion

    /// <summary>
    ///     Generates a random AES key used on yealink phones. Example: y5b0K3z0h3Kw0h03
    /// </summary>
    public static string GenerateRandomYealinkAesKey(int length = 16)
    {
        // Maybe RandomNumberGenerator is thread safe but just to be sure
        lock (Phone.alphanumericMainCharacters)
        {
            char[] p = new char[length];
            for (int i = 0; i < length; i++)
                p[i] = Phone.alphanumericMainCharacters[RandomNumberGenerator.GetInt32(0, Phone.alphanumericMainCharacters.Length)];
            return new string(p);
        }
    }

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;

        // enable searching fast by id of phone
        yield return new MongoDbIndex(collection, nameof(this.IdPhone))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));

        // enable searching fast by ip address
        yield return new MongoDbIndex(collection, nameof(this.Ip))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));
    }

    #endregion
}

#endif