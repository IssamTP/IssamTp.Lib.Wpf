using System.Resources;

namespace IssamTp.Lib.Wpf
{
    /// <summary>Gestione di alcune delle funzionalità di base WPF.</summary>
    public interface IGestoreWpf
    {
        /// <summary>Accede alle risorse dell'assembly per ottenere una stringa (traduzioni).</summary>
        /// <param name="stringId">Id della stringa.</param>
        /// <returns>Stringa come da tabella.</returns>
        string GetStringaDaRisorse(string stringId);

        /// <summary>Inizializza il gestore WPF con le risorse dell'applicativo.</summary>
        /// <param name="manager">Gestore delle risorse dell'applicativo.</param>
        void Inizializza(ResourceManager manager);
    }
}
