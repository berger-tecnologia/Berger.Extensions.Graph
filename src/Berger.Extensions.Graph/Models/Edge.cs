using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class Edge : BaseEntity
    {
        public Guid? ExternalId { get; set; }

        public Guid SourceNodeId { get; set; }
        public Node SourceNode { get; set; }

        public Guid TargetNodeId { get; set; }
        public Node TargetNode { get; set; }

        public Guid? SourcePortId { get; set; }
        public Port SourcePort { get; set; }

        public Guid? TargetPortId { get; set; }
        public Port TargetPort { get; set; }

        public RelationshipType RelationshipType { get; set; }

        public string Path { get; set; }
        public int Index { get; set; } = 0;
    }
}