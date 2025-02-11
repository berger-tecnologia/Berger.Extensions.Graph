using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class NodeParameterGroup : BaseEntity
    {
        public Guid ParameterGroupId { get; set; }
        public ParameterGroup ParameterGroup { get; set; }
        public Guid NodeId { get; set; }
        public Node Node { get; set; }
    }
}