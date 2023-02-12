namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Server where ublux website lives
/// </summary>
public partial class CloudServiceWebHost : CloudService
{
    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType
    {
        get => CloudServiceType.WH;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}
