using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class Port : BaseEntity
    {
        public Guid NodeId { get; set; }
        public Node Node { get; set; }
        public string Group { get; set; }
        public string Label { get; set; }
    }
}