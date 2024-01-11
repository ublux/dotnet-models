#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Virtual receptionist
/// </summary>
public partial class CallFlowLogic 
{    
    /// <summary>
    ///     Traverse tree
    /// </summary>
    public IEnumerable<FlowNode> TraverseTree()
    {
        // yield return Tree;

        foreach (var node in Tree.TraverseNode())
            yield return node;
    }

    /// <summary>
    ///     Traverse tree
    /// </summary>
    public IEnumerable<FlowNode> TraverseTreeAndBookmarks()
    {
        // traverse main tree
        foreach(var node in TraverseTree())
            yield return node;

        // traverse bookmarks
        foreach (var bk in Bookmarks)
            foreach (var node in bk.TraverseNode())
                yield return node;
    }

    /// <summary>
    ///     Create default logic
    /// </summary>
    public static CallFlowLogic CreateDefault(RunningApplicationInstance instance, string idAccount)
    {
        return new CallFlowLogic
        {
            DateCreated = DateTime.UtcNow,
            BuiltId = BuildId(instance),
            FriendlyName = "Default",
            IdAccount = idAccount,
            IdsTags = [],
            DateDeleted = null,
            Description = "Default IVR",
            Tree = new NodeSay
            {
                Child = new NodeHangup(),
                Text = $"This number is not configured. Please configure your new number at {Constants.Domain}",
                Voice = "Amy",
                CollectDigits = false,
                Timeout = 1,
                MaxNumberOfDigits = 1
            }
        };
    }
}

#endif