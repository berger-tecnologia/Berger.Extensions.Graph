using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class ParameterContract : BaseEntity
    {
        #region Properties
        public Guid GroupId { get; set; }
        public Guid? EntityId { get; set; }
        // Add Virtual
        public string Name { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int Index { get; set; } = 0;
        public int Sequence { get; set; } = 0;
        #endregion

        #region Methods
        #endregion
    }
}