using System.Globalization;
using System.Reflection;
using System.Resources;

namespace IssamTp.Lib.Wpf
{
    /// <summary>Implementazione dell'interfaccia IGestoreWpf.</summary>
    public class GestoreWpf : IGestoreWpf
    {
        #region
        /// <summary>Indica se il Manager è stato correttamente inizializzato.</summary>
        protected bool Inizializzato;
        /// <summary>Gestore delle risorse, deve essere impostato.</summary>
        protected ResourceManager Manager;
        #endregion

        #region Costruttore
        /// <summary>
        /// Costruttore predefinito.
        /// </summary>
        public GestoreWpf()
        {
            Manager = new ResourceManager("IssamTp.Lib.Wpf.Strings.3.resources", Assembly.GetCallingAssembly());
        }
        #endregion

        #region IGestoreWpf
        public string GetStringaDaRisorse(string stringId)
        {
            string stringaRisorse = string.Empty;
            try
            {
                if (Manager != null && Inizializzato)
                {
                    string? risorsa = Manager.GetString(stringId, CultureInfo.CurrentUICulture);
                    stringaRisorse = risorsa != null ? risorsa : string.Empty;
                }
            }
            catch
            {
                stringaRisorse = string.Empty;
            }
            return stringaRisorse;
        }

        public void Inizializza(ResourceManager manager)
        {
            Manager = manager;
        }
        #endregion
    }
}
