namespace Berger.Extensions.Graph
{
    public class Parameter : ParameterContract
    {
        // Temporários
        public Guid? TargetNodeId { get; set; }
        public Guid? ParameterGroupId { get; set; }        

        #region Properties
        public Pattern Pattern { get; set; }
        //public Language Language { get; set; }
        //public ParameterGroup ParameterGroup { get; set; }
        #endregion

        #region Constructors
        public Parameter()
        {
        }
        #endregion

        #region Methods
        public Parameter(Guid parameterId)
        {
            this.SetId(parameterId);
        }
        #endregion
    }
}