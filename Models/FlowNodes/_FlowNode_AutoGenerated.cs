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
[JsonSubtypes.KnownSubType(typeof(NodeIfWeekDay), /*                          */ nameof(FlowNodeType.IfWeekDay))]
[JsonSubtypes.KnownSubType(typeof(NodeWeekDays), /*                           */ nameof(FlowNodeType.WeekDays))]
[JsonSubtypes.KnownSubType(typeof(NodeAnyWeekDay), /*                         */ nameof(FlowNodeType.AnyWeekDay))]
[JsonSubtypes.KnownSubType(typeof(NodeExtension), /*                          */ nameof(FlowNodeType.Extension))]
[JsonSubtypes.KnownSubType(typeof(NodeDynamicExtension), /*                   */ nameof(FlowNodeType.DynamicExtension))]
[JsonSubtypes.KnownSubType(typeof(NodeIfDialStatus), /*                       */ nameof(FlowNodeType.IfDialStatus))]
[JsonSubtypes.KnownSubType(typeof(NodeDialStatus), /*                         */ nameof(FlowNodeType.DialStatus))]
[JsonSubtypes.KnownSubType(typeof(NodeAnyDialStatus), /*                      */ nameof(FlowNodeType.AnyDialStatus))]
[JsonSubtypes.KnownSubType(typeof(NodeIfPhoneDisconnected), /*                */ nameof(FlowNodeType.IfPhoneDisconnected))]
[JsonSubtypes.KnownSubType(typeof(NodePhoneConnected), /*                     */ nameof(FlowNodeType.PhoneConnected))]
[JsonSubtypes.KnownSubType(typeof(NodePhoneDisconnected), /*                  */ nameof(FlowNodeType.PhoneDisconnected))]
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
    typeof(NodeIfWeekDay),
    typeof(NodeWeekDays),
    typeof(NodeAnyWeekDay),
    typeof(NodeExtension),
    typeof(NodeDynamicExtension),
    typeof(NodeIfDialStatus),
    typeof(NodeDialStatus),
    typeof(NodeAnyDialStatus),
    typeof(NodeIfPhoneDisconnected),
    typeof(NodePhoneConnected),
    typeof(NodePhoneDisconnected),
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
        #if UBLUX_Release || RELEASE
        set;
        #else
        #endif
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeIfWeekDay : FlowNode, IMultipleChildren
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.IfWeekDay;
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(FlowNode))]
    public List<FlowNode> Children { get; set; } = new List<FlowNode>();
}

/// <summary></summary>
public partial class NodeWeekDays : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.WeekDays;
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeAnyWeekDay : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.AnyWeekDay;
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeIfDialStatus : FlowNode, IMultipleChildren
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.IfDialStatus;
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(FlowNode))]
    public List<FlowNode> Children { get; set; } = new List<FlowNode>();
}

/// <summary></summary>
public partial class NodeDialStatus : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.DialStatus;
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeAnyDialStatus : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.AnyDialStatus;
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodeIfPhoneDisconnected : FlowNode, IMultipleChildren
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.IfPhoneDisconnected;
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(FlowNode))]
    public List<FlowNode> Children { get; set; } = new List<FlowNode>();
}

/// <summary></summary>
public partial class NodePhoneConnected : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.PhoneConnected;
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}

/// <summary></summary>
public partial class NodePhoneDisconnected : FlowNode, IOneChild
{
    /// <inheritdoc />
    public override FlowNodeType FlowNodeType
    {
        get => FlowNodeType.PhoneDisconnected;
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
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
        #if UBLUX_Release || RELEASE
        set { }
        #else
        #endif
    }

    /// <inheritdoc />
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(FlowNode))]
    public FlowNode? Child { get; set; }
}


