namespace Ublux.Communications.Models.FlowNodes;

public abstract partial class FlowNode
{
    /// <summary>
    ///     Traverse node
    /// </summary>
    public IEnumerable<FlowNode> TraverseNode()
    {
        FlowNode node = this;

        if (node != null)
        {
            if (node is IOneChild o)
            {
                if (o.Child != null)
                {
                    yield return o.Child;

                    foreach (var subChild in o.Child.TraverseNode())
                        yield return subChild;
                }
            }
            else if (node is IMultipleChildren m)
            {
                foreach (var child in m.Children)
                {
                    if (child is null) continue;

                    yield return child;

                    foreach (var subChild in child.TraverseNode())
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
