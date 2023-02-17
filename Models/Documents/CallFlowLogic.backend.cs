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

        foreach (var node in TraverseNode(Tree))
            yield return node;
    }

    /// <summary>
    ///     Traverse node
    /// </summary>
    public IEnumerable<FlowNode> TraverseNode(FlowNode node)
    {
        if (node != null)
        {
            if (node is IOneChild o)
            {
                if (o.Child != null)
                {
                    yield return o.Child;

                    foreach (var subChild in TraverseNode(o.Child))
                        yield return subChild;
                }
            }
            else if (node is IMultipleChildren m)
            {
                foreach (var child in m.Children)
                {
                    if (child is null) continue;

                    yield return child;

                    foreach (var subChild in TraverseNode(child))
                        yield return subChild;
                }
            }
            else
            {
                throw new Exception($"Invalid node {node.GetType().Name}. It must either be {nameof(IMultipleChildren)} or {nameof(IOneChild)}");
            }
        }

    }
}

#endif