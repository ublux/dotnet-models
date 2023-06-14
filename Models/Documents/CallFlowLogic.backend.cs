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
        yield return Tree;

        foreach (var node in Tree.TraverseNode())
            yield return node;
    }

    /// <summary>
    ///     Create default logic
    /// </summary>
    public static CallFlowLogic CreateDefault(RunningApplicationInstance instance, string idAccount)
    {
        return new CallFlowLogic()
        {
            DateCreated = DateTime.UtcNow,
            BuiltId = CallFlowLogic.BuildId(instance),
            FriendlyName = "Default",
            IdAccount = idAccount,
            IdsTags = new(),
            DateDeleted = null,
            Description = "Default IVR",
            Tree = new NodeSay()
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