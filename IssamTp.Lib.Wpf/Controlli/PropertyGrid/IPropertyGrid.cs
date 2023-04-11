using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IssamTp.Lib.Wpf
{
    /// <summary>Il View Model che vuole interfacciarsi alla PropertyGridUC deve implementare questa interfaccia.</summary>
    public interface IPropertyGridVM
    {
        /// <summary>Elenco delle proprietà da visualizzare nella griglia.</summary>
        ObservableCollection<PropertyGridRowVM> ProprietaValori
        {
            get;
            set;
        }
    }

    /// <summary>View Model generico della property grid.</summary>
    /// <remarks>L'oggetto implementa per conto suo il pattern notifyproperty per evitare dipendenze da librerie terze.</remarks>
    public class PropertyGridRowVM : INotifyPropertyChanged
    {
        /// <summary>Valore della proprietà.</summary>
        public object? Valore
        {
            get => _Valore;
            set
            {
                if (_Valore != null && !_Valore.Equals(value))
                {
                    _Valore = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private object? _Valore;

        /// <summary>Nome della proprietà.</summary>
        public string Proprieta
        {
            get => _Proprieta;
            set
            {
                if (!_Proprieta.Equals(value, StringComparison.Ordinal))
                {
                    _Proprieta = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Proprieta = string.Empty;

        /// <summary>Quando Valore è un enum, qui si trovano tutti i valori possibili.</summary>
        public ObservableCollection<object?> ValoriPossibili
        {
            get;
            private set;
        } = new ObservableCollection<object?>();

        /// <summary>Contiene il tipo di Valore.</summary>
        public Type? TipoProprieta
        {
            get;
            private set;
        }

        #region INotifyPropertyChanged
        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>Notifica all'osservatore che la proprietà specificata ha cambiato valore.</summary>
        /// <param name="propertyName">Nome della proprietà cambiata.</param>
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Costruttori
        /// <summary>Costruttore predefinito.</summary>
        internal PropertyGridRowVM()
            : base()
        {
        }

        /// <summary>Questo costruttore permette di inizializzare una generica riga della property grid.</summary>
        /// <param name="nomeProprieta">Nome della proprietà.</param>
        /// <param name="valore">Valore della proprietà.</param>
        public PropertyGridRowVM(string nomeProprieta, object valore)
            : base()
        {
            Valore = valore;
            Proprieta = nomeProprieta;
            TipoProprieta = Valore.GetType();
            if (Valore is Enum)
            {
                foreach (object? valorePossibile in TipoProprieta.GetEnumValues())
                {
                    ValoriPossibili.Add(valorePossibile);
                }
            }
        }
        #endregion

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{_Proprieta} - {_Valore}";
        }
    }
}
