using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class AttributeGroup : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Attribute> Attributes { get; set; }
        public ICollection<NodeAttributeGroup> NodeAttributeGroups { get; set; }
    }
}