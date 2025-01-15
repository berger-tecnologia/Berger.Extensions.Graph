using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class NodeAttributeGroup : BaseEntity
    {
        public Guid NodeId { get; set; }
        public Node Node { get; set; }
        public Guid AttributeGroupId { get; set; }
        public AttributeGroup AttributeGroup { get; set; }
    }
}