using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class Node : BaseEntity
    {
        public Guid NodeTypeId { get; set; }
        public NodeType NodeType { get; set; }
        public Guid? EntityTypeId { get; set; }
        public Guid? EntityId { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public int Index { get; set; }
        public ICollection<Port> Ports { get; set; }
        public ICollection<Edge> OutgoingEdges { get; set; }
        public ICollection<Edge> IncomingEdges { get; set; }
        public ICollection<NodeAttributeGroup> NodeAttributeGroups { get; set; }
    }
}