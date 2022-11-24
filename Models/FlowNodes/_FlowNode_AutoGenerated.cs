namespace Ublux.Communications.Models.FlowNodes;

/* THIS FILE IS AUTO GENERATED. DO NOT DELETE/MODIFY */
/* Contains flow nodes */

/// <summary>
///     A node in a call flow, sms flow or whatsapp flow
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(FlowNodeType))]
[JsonSubtypes.KnownSubType(typeof(NodeSay), /*                                */ nameof(FlowNodeType.Say))]
[JsonSubtypes.KnownSubType(typeof(NodePlay), /*                               */ nameof(FlowNodeType.Play))]
[JsonSubtypes.KnownSubType(typeof(NodeIfDigits), /*                           */ nameof(FlowNodeType.IfDigits))]
[JsonSubtypes.KnownSubType(typeof(NodeDigits), /*                             */ nameof(FlowNodeType.Digits))]
[JsonSubtypes.KnownSubType(typeof(NodeAnyDigits), /*                          */ nameof(FlowNodeType.AnyDigits))]
[JsonSubtypes.KnownSubType(typeof(NodeIfTime), /*                             */ nameof(FlowNodeType.IfTime))]
[JsonSubtypes.KnownSubType(typeof(NodeTime), /*                               */ nameof(FlowNodeType.Time))]
[JsonSubtypes.KnownSubType(typeof(NodeAnyTime), /*                            */ nameof(FlowNodeType.AnyTime))]
[JsonSubtypes.KnownSubType(typeof(NodeExtension), /*                          */ nameof(FlowNodeType.Extension))]
[JsonSubtypes.KnownSubType(typeof(NodeDynamicExtension), /*                   */ nameof(FlowNodeType.DynamicExtension))]
[JsonSubtypes.KnownSubType(typeof(NodeIfLineOffline), /*                      */ nameof(FlowNodeType.IfLineOffline))]
[JsonSubtypes.KnownSubType(typeof(NodeLineOnline), /*                         */ nameof(FlowNodeType.LineOnline))]
[JsonSubtypes.KnownSubType(typeof(NodeLineOffline), /*                        */ nameof(FlowNodeType.LineOffline))]
[JsonSubtypes.KnownSubType(typeof(NodeCall), /*                               */ nameof(FlowNodeType.Call))]
[JsonSubtypes.KnownSubType(typeof(NodePause), /*                              */ nameof(FlowNodeType.Pause))]
[JsonSubtypes.KnownSubType(typeof(NodeGoTo), /*                               */ nameof(FlowNodeType.GoTo))]
[JsonSubtypes.KnownSubType(typeof(NodeBookmark), /*                           */ nameof(FlowNodeType.Bookmark))]
[JsonSubtypes.KnownSubType(typeof(NodeComment), /*                            */ nameof(FlowNodeType.Comment))]
[JsonSubtypes.KnownSubType(typeof(NodeAPI), /*                                */ nameof(FlowNodeType.API))]
[JsonSubtypes.KnownSubType(typeof(NodeCallBackAPI), /*                        */ nameof(FlowNodeType.CallBackAPI))]
[JsonSubtypes.KnownSubType(typeof(NodeHangup), /*                             */ nameof(FlowNodeType.Hangup))]
[BsonKnownTypes(
    typeof(NodeSay),
    typeof(NodePlay),
    typeof(NodeIfDigits),
    typeof(NodeDigits),
    typeof(NodeAnyDigits),
    typeof(NodeIfTime),
    typeof(NodeTime),
    typeof(NodeAnyTime),
    typeof(NodeExtension),
    typeof(NodeDynamicExtension),
    typeof(NodeIfLineOffline),
    typeof(NodeLineOnline),
    typeof(NodeLineOffline),
    typeof(NodeCall),
    typeof(NodePause),
    typeof(NodeGoTo),
    typeof(NodeBookmark),
    typeof(NodeComment),
    typeof(NodeAPI),
    typeof(NodeCallBackAPI),
    typeof(NodeHangup)
)]
public abstract partial class FlowNode
{
    /// <summary>
    ///     Type of node. Thanks to this property we should be able to deserialize the node
    /// </summary>
    public abstract FlowNodeType FlowNodeType
    {
        get;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set;
    }
}

/// <summary>
///     If a FlowNode can only have one child
/// </summary>
public interface IOneChild
{
    /// <summary>
    ///     Child
    /// </summary>
    FlowNode? Child { get; set; }
}

/// <summary>
///     If a FlowNode can have multiple children
/// </summary>
public interface IMultipleChildren
{
    /// <summary>
    ///     Child
    /// </summary>
    List<FlowNode> Children { get; set; }
}

/// <summary></summary>
public partial class NodeSay : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.Say;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodePlay : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.Play;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeIfDigits : FlowNode, IMultipleChildren
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.IfDigits;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public List<FlowNode> Children { get; set; } = new List<FlowNode>();
}

/// <summary></summary>
public partial class NodeDigits : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.Digits;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeAnyDigits : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.AnyDigits;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeIfTime : FlowNode, IMultipleChildren
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.IfTime;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public List<FlowNode> Children { get; set; } = new List<FlowNode>();
}

/// <summary></summary>
public partial class NodeTime : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.Time;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeAnyTime : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.AnyTime;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeExtension : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.Extension;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeDynamicExtension : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.DynamicExtension;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeIfLineOffline : FlowNode, IMultipleChildren
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.IfLineOffline;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public List<FlowNode> Children { get; set; } = new List<FlowNode>();
}

/// <summary></summary>
public partial class NodeLineOnline : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.LineOnline;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeLineOffline : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.LineOffline;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeCall : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.Call;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodePause : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.Pause;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeGoTo : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.GoTo;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeBookmark : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.Bookmark;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeComment : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.Comment;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeAPI : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.API;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeCallBackAPI : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.CallBackAPI;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeHangup : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.Hangup;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}


