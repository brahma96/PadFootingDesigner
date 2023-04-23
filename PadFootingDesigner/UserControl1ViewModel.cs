using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PadFootingDesigner
{
    public class UserControl1ViewModel
    {
        public UserControl1ViewModel()
        {
            HelloButton = new RelayCommand((parameter) => MessageBox.Show("Hello from relaycommand!"));
            
        }

        //private void ExecuteCommand()
        //{
        //    MessageBox.Show("Hello from RelayCommand!");
        //}

        public ICommand HelloButton { get; }

        public string TextBoxWords { get; set; } = "text_set_in_viewmodel";

        //private void ExecuteCommand()
        //{
        //    MessageBox.Show("Hello from RelayCommand!");
        //}
    }
}
