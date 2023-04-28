using PadFootingDesigner.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PadFootingDesigner.Controls
{
    /// <summary>
    /// Interaction logic for OldPadDesigner.xaml
    /// </summary>
    public partial class OldPadDesigner : UserControl
    {
        public OldPadDesigner()
        {
            InitializeComponent();

            //this.DataContext = this;

            //SelectShape = new RelayCommand(ExecuteCommandShape);
        }

        //public ICommand SelectShape { get; set; }

        //public void ExecuteCommandShape(object obj)
        //{
        //    MessageBox.Show("Shapes!");
        //}
    }
}
