using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class NodeType : BaseEntity
    {
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        //public string Path { get; set; }
        public int Sequence { get; set; } = 0;
    }
}