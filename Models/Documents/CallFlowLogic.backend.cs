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
}

#endif