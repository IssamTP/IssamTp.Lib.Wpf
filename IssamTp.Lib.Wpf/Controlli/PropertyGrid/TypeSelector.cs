using System;
using System.Windows.Controls;
using System.Windows;

namespace IssamTp.Lib.Wpf
{
    /// <summary>Permette di scegliere tra tre DataTemplate distinguendo tra bool, Enum e tutti gli altri.</summary>
    public class TypeSelector : DataTemplateSelector
    {
        #region Proprietà
        /// <summary>Identifica il template per tipo di dato bool.</summary>
        public DataTemplate? BoolDataTemplate
        {
            get;
            set;
        }

        /// <summary>Identifica il template per tipo di dato Enum.</summary>
        public DataTemplate? EnumDataTemplate
        {
            get;
            set;
        }

        /// <summary>Identifica il template predefinito.</summary>
        public DataTemplate? IntegralDataTemplate
        {
            get;
            set;
        }
        #endregion

        /// <summary>Seleziona il template a seconda del tipo di item.</summary>
        /// <param name="item">View model che contiene la proprietà da rimappare.</param>
        /// <param name="container">Non utilizato.</param>
        /// <returns>Il data template opportuno.</returns>
        /// <exception cref="MemberAccessException">L'eccezione viene lanciata quando non è stato definito il template per il tipo di dato associato.</exception>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is PropertyGridRowVM rowVM)
            {
                if (rowVM.Valore is Enum && EnumDataTemplate != null)
                {
                    return EnumDataTemplate;
                }
                else if (rowVM.Valore is bool && BoolDataTemplate != null)
                {
                    return BoolDataTemplate;
                }
                else if (IntegralDataTemplate != null)
                {
                    return IntegralDataTemplate;
                }
                else
                {
                    throw new MemberAccessException("No data template set.");
                }
            }
            else if (IntegralDataTemplate != null)
            {
                return IntegralDataTemplate;
            }
            else
            {
                throw new MemberAccessException("No data template set.");
            }
        }
    }
}
