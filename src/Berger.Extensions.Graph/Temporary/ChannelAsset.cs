using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class ChannelNode : BaseEntity
    {
        public Guid ChannelId { get; set; }
        public Guid NodeId { get; set; }
        //public Channel Channel { get; set; }
    }
    public class NodeExpression : BaseEntity
    {
        public Guid NodeId { get; set; }
        public Guid PatternId { get; set; }
        public Pattern Pattern { get; set; }
    }
}