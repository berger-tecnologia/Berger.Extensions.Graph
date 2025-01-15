using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class NodeType : BaseEntity
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
}