namespace Berger.Extensions.Graph
{
    public class Pattern : PatternContract
    {
        #region Properties
        //public List<Parameter> Parameters { get; set; }
        #endregion

        #region Constructors
        public Pattern()
        {
        }
        public Pattern(string expression)
        {
            this.Expression = expression;
        }
        #endregion
    }
}