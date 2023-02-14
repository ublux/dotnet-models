#if UBLUX_BACKEND


namespace Ublux.Communications.Models;

/// <summary>
///     MongoDB supports subdocuments
/// </summary>
public abstract partial class UbluxSubDocument
{
    /// <summary>
    ///     Set id
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    [BsonIgnore]
    [JsonIgnore]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public BuiltId BuiltId
    {
        set
        {
            this.id = value.Id;
        }
    }

}

#endif
