using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class NodeType : BaseEntity
    {
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int Index { get; set; }
    }
}