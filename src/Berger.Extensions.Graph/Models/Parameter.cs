namespace Berger.Extensions.Graph
{
    public class Parameter : ParameterContract
    {
        // Pendente: Traduções
        //public string LanguageCode { get; set; } // "en", "es", "fr"
        //public string Value { get; set; } // Translated value

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