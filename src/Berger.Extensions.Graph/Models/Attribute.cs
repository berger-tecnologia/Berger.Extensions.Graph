using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class Attribute : BaseEntity
    {
        public Guid AttributeGroupId { get; set; }
        public AttributeGroup AttributeGroup { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}