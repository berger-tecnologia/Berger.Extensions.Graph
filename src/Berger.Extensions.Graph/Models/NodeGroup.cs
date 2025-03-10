using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class NodeGroup : BaseEntity
    {
        public Node Node { get; set; }
        public Guid NodeId { get; set; }

        public Guid GroupId { get; set; }

        //public Parameter Parameter { get; set; }
        //public Guid ParameterId { get; set; }

        //public Guid ParameterGroupId { get; set; }
        //public ParameterGroup ParameterGroup { get; set; }
    }
}