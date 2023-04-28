using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace PadFootingDesigner.Windows
{
    /// <summary>
    /// Interaction logic for DataGridSample.xaml
    /// </summary>
    public partial class DataGridSample : UserControl, INotifyPropertyChanged
    {
        private List<Employee> employees;

        public DataGridSample()
        {
            InitializeComponent();
            this.DataContext = this;

            Employees = new List<Employee>()
            {
                new Employee(){Name = "xyz", Selection=true},
                new Employee(){Name = "abc", Selection=false},
                new Employee(){Name = "ghi", Selection=true},
                new Employee(){Name = "jkl", Selection=true},
                new Employee(){Name = "mno", Selection=false}
            };
        }

        public List<Employee> Employees
        {
            get
            {
                return employees;
            }

            set
            {
                employees = value;
                OnPropertyChanged("Employees");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }

    public class Employee
    {
        public bool Selection { get; set; }
        public string Name { get; set; }
    }
}
