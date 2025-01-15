using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class Edge : BaseEntity
    {
        public Guid SourceNodeId { get; set; }
        public Node SourceSourceNode { get; set; }
        public Guid TargetNodeId { get; set; }
        public Node TargetNode { get; set; }
        public Guid SourcePortId { get; set; }
        public Port SourcePort { get; set; }
        public Guid TargetPortId { get; set; }
        public Port TargetPort { get; set; }
        public string Label { get; set; }     
    }
}