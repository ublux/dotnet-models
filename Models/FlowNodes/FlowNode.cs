namespace Ublux.Communications.Models.FlowNodes;

public abstract partial class FlowNode
{
    /// <summary>
    ///     Traverse node. It will yield the current node!
    /// </summary>
    public IEnumerable<FlowNode> TraverseNode()
    {
        yield return this;

        if (this is IOneChild o)
        {
            if (o.Child != null)
            {
                foreach (var subChild in o.Child.TraverseNode())
                    yield return subChild;
            }
        }
        else if (this is IMultipleChildren m)
        {
            foreach (var child in m.Children)
            {
                if (child is null) continue;

                foreach (var subChild in child.TraverseNode())
                    yield return subChild;
            }
        }
        else
        {
            throw new Exception($"Invalid node {this.GetType().Name}. It must either be {nameof(IMultipleChildren)} or {nameof(IOneChild)}");
        }
    }
}
