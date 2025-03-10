using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class Node : BaseEntity
    {
        // Temporários
        //public Guid TenantId { get; set; }
        //public Guid? SourceNodeId { get; set; }
        //public string Environment { get; set; }
        //public Guid? TokenId { get; set; }
        //public Guid? ResolverId { get; set; }
        public Guid? TargetNodeId { get; set; }
        // Temporários

        public Guid NodeTypeId { get; set; }
        public NodeType NodeType { get; set; }
        public Guid? CategoryId { get; set; }
        public RelationshipType RelationshipType { get; set; }
        public string Name { get; set; }
        //public string Label { get; set; }
        //public string File { get; set; }
        //public string Uuid { get; set; }
        //public string Uri { get; set; }
        //public string Comment { get; set; }
        //public string Content { get; set; }
        //public string Version { get; set; }
        //public string Action { get; set; }
        //public string Description { get; set; }
        //public string Icon { get; set; }
        //public double PositionX { get; set; }
        //public double PositionY { get; set; }
        public int Index { get; set; }
        public ICollection<Port> Ports { get; set; }
        public ICollection<Edge> OutgoingEdges { get; set; }
        public ICollection<Edge> IncomingEdges { get; set; }
        public ICollection<NodeGroup> NodeGroups { get; set; }
    }
}