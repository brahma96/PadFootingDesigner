using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PadFootingDesigner
{
    public class ProjectTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = (FrameworkElement)container;
            
            if (item is UserControl1ViewModel)
            {
                element.FindResource("helooUserControl");
            }

            return item as DataTemplate;
        }
    }
}
