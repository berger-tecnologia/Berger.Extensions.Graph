using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class ParameterGroup : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Parameter> Parameters { get; set; }

        public ICollection<NodeParameterGroup> NodeParameterGroups { get; set; }
    }
}