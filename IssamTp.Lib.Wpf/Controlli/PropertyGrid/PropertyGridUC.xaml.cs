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
        public static readonly DependencyProperty EtichettaTestataProprietaProperty = DependencyProperty.Register("EtichettaTestataProprieta", typeof(string), typeof(PropertyGridUC), new PropertyMetadata("Proprietà"));
        #endregion

        #region EtichettaTestataValore
        /// <summary>Impostare questa proprietà per definire l'etichetta della testata della colonna "valore".</summary>
        public string EtichettaTestataValore
        {
            get { return (string)GetValue(EtichettaTestataValoreProperty); }
            set { SetValue(EtichettaTestataValoreProperty, value); }
        }

        /// <summary>Dependency property della etichetta della colonna "valore".</summary>
        public static readonly DependencyProperty EtichettaTestataValoreProperty = DependencyProperty.Register("EtichettaTestataValore", typeof(string), typeof(PropertyGridUC), new PropertyMetadata("Valore"));
        #endregion

        #region ComboBoxEditingStyle
        /// <summary>Impostare questo stile per decorare le combo box.</summary>
        public Style ComboBoxEditingStyle
        {
            get { return (Style)GetValue(ComboBoxEditingStyleProperty); }
            set { SetValue(ComboBoxEditingStyleProperty, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty ComboBoxEditingStyleProperty = DependencyProperty.Register("ComboBoxEditingStyle", typeof(Style), typeof(PropertyGridUC), new PropertyMetadata(new Style(typeof(ComboBox))));
        #endregion

        #region CheckBoxEditingStyle
        /// <summary>
        /// 
        /// </summary>
        public Style CheckBoxEditingStyle
        {
            get { return (Style)GetValue(CheckBoxEditingStyleProperty); }
            set { SetValue(CheckBoxEditingStyleProperty, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty CheckBoxEditingStyleProperty = DependencyProperty.Register("CheckBoxEditingStyle", typeof(Style), typeof(PropertyGridUC), new PropertyMetadata(new Style(typeof(CheckBox))));
        #endregion

        #region TextBoxEditingStyle
        /// <summary>Impostare questo stile per decorare le TextBox.</summary>
        public Style TextBoxEditingStyle
        {
            get { return (Style)GetValue(TextBoxEditingStyleProperty); }
            set { SetValue(TextBoxEditingStyleProperty, value); }
        }

        /// <summary>Proprietà della text box.</summary>
        public static readonly DependencyProperty TextBoxEditingStyleProperty = DependencyProperty.Register("TextBoxEditingStyle", typeof(Style), typeof(PropertyGridUC), new PropertyMetadata(new Style(typeof(TextBox))));
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
