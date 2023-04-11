using System.Windows;
using System.Windows.Controls;

namespace IssamTp.Lib.Wpf
{
    /// <summary>
    /// Logica di interazione per PropertyGridUC.xaml
    /// </summary>
    public partial class PropertyGridUC : UserControl
    {
        #region Dependency Properties

        #region EtichettaTestataProprietà
        /// <summary>Impostare questa proprietà per definire l'etichetta della testata della colonna "proprietà".</summary>
        public string EtichettaTestataProprieta
        {
            get { return (string)GetValue(EtichettaTestataProprietaProperty); }
            set { SetValue(EtichettaTestataProprietaProperty, value); }
        }

        /// <summary>Dependency property della etichetta della colonna "proprietà".</summary>
        public static readonly DependencyProperty EtichettaTestataProprietaProperty = DependencyProperty.Register("EtichettaTestataProprieta", typeof(string), typeof(PropertyGridUC), new PropertyMetadata(string.Empty));
        #endregion

        #region EtichettaTestataValore
        /// <summary>Impostare questa proprietà per definire l'etichetta della testata della colonna "valore".</summary>
        public string EtichettaTestataValore
        {
            get { return (string)GetValue(EtichettaTestataValoreProperty); }
            set { SetValue(EtichettaTestataValoreProperty, value); }
        }

        /// <summary>Dependency property della etichetta della colonna "valore".</summary>
        public static readonly DependencyProperty EtichettaTestataValoreProperty = DependencyProperty.Register("EtichettaTestataValore", typeof(string), typeof(PropertyGridUC), new PropertyMetadata(string.Empty));
        #endregion

        #endregion

        #region Costruttore
        /// <summary>Costruttore predefinito.</summary>
        public PropertyGridUC()
        {
            InitializeComponent();
        }
        #endregion
    }
}
