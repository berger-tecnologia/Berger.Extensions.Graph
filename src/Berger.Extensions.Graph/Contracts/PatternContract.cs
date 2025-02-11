using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class PatternContract : BaseEntity
    {
        #region Properties
        public string Name { get; set; }
        public string Property { get; set; }
        public ExpressionType ExpressionType { get; set; }
        public string Expression { get; set; }
        #endregion
    }
}