using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Graph
{
    public class ParameterContract : BaseEntity
    {
        #region Properties
        public Guid? PatternId { get; set; }
        public Guid? LanguageId { get; set; }
        //public Guid ParameterGroupId { get; set; }
        public DataType DataType { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int Index { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}