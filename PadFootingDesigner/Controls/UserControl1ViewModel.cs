using PadFootingDesigner.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PadFootingDesigner.Controls
{
    public class UserControl1ViewModel
    {
        public UserControl1ViewModel()
        {
            HelloButton = new RelayCommand((parameter) => MessageBox.Show("Hello from relaycommand!"));
            
        }

        public ICommand HelloButton { get; }

        public string TextBoxWords { get; set; } = "text_set_in_viewmodel";

    }
}
