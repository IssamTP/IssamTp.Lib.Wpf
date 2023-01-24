using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace IssamTp.Lib.Wpf
{
    /// <summary>Converter XAML: da bool a Visibility, negato.</summary>
    public class InverseBooleanToVisibilityConverter : IValueConverter
    {
        /// <summary>Converte un System.Boolean in Visibility.Collapsed o Visibility.Visible.</summary>
        /// <param name="value">Un System.Object che dovrebbe essere un System.Boolean.</param>
        /// <param name="targetType">Non utilizzato.</param>
        /// <param name="parameter">Non utilizzato.</param>
        /// <param name="culture">Non utilizzato.</param>
        /// <returns>Se value è bool, allora associa Collapsed a true e Visible a false. Se il valore non è bool allora Collapsed.</returns>
        /// <see cref="System.Boolean"/>
        /// <see cref="System.Windows.Visibility"/>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visibilita = Visibility.Collapsed;
            if (value is bool visibile)
            {
                visibilita = visibile ? Visibility.Collapsed: Visibility.Visible;
            }
            return visibilita;
        }

        /// <summary>Converte un System.Windows.Visibility in System.Boolean true o false.</summary>
        /// <param name="value">Un System.Object che dovrebbe essere un System.Windows.Visibility.</param>
        /// <param name="targetType">Non utilizzato.</param>
        /// <param name="parameter">Non utilizzato.</param>
        /// <param name="culture">Non utilizzato.</param>
        /// <returns>Se value è System.Windows.Visibility, allora associa Collapsed a true e Visible a false. Se il valore non è System.Windows.Visibility allora false.</returns>
        /// <see cref="System.Boolean"/>
        /// <see cref="System.Windows.Visibility"/>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool visibile = true;
            if (value is Visibility visibilita)
            {
                visibile = visibilita == Visibility.Hidden || visibilita == Visibility.Collapsed;
            }
            return visibile;
        }
    }
}
