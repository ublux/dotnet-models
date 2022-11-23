namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Virtual receptionist
/// </summary>
public partial class CallFlowLogic : UbluxDocument, IReferencesTags
{
    #region Properties

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> Tags { get; set; } = new();

    /// <summary>
    ///     Name of virtual receptionist
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string FriendlyName { get; set; }

    /// <summary>
    ///     Description of virtual receptionist
    /// </summary>
    [AllowUpdate(true)]
    public string? Description { get; set; }

    ///// <summary>
    /////     XML containing the call flow rules
    ///// </summary>
    //[AllowUpdate(true)]
    //[IsUbluxRequired]
    //public required string XmlTree { get; set; }

    /// <summary>
    ///     XML containing the call flow rules
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required FlowNode Tree { get; set; }

    #endregion
}
