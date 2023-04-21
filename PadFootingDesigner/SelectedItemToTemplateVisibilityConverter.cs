using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace PadFootingDesigner
{
    public class SelectedItemToTemplateVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool chosenDataTemplate = (bool)value;
            //var groupBox = (GroupBox)parameter;
            Visibility result = Visibility.Collapsed;

            if (chosenDataTemplate)
            {
                result = Visibility.Visible;
            }
            else
            {
                result = Visibility.Collapsed;
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
