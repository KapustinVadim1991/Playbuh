using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLogic.Model;
using Client.PlaybuhService;
using DevExpress.Xpf.Core;

namespace Client
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow, INotifyPropertyChanged
    {
        private Employee _selectedEmployee;

        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>
        {
            new Employee
            {
                Id = 1,
                FirstName = "some",
                LastName = "last",
                MiddleName = "middle",
                Description = "descr"
            }
        };

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public MainWindow()
        {
            InitializeComponent();
            Initialize();

            employeesGrid.DataContext = this;
        }

        private void Initialize()
        {
            Employees = new ObservableCollection<Employee>();

            try
            {
                var service = new ServiceNetworkClient();

                LoadEmployees(service);


            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}\n{e.InnerException}\n{e.StackTrace}");
            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private void LoadEmployees(ServiceNetworkClient service)
        {
            var employees = service.GetEmployees(false);

            foreach (var emp in employees)
            {
                Employees.Add(emp);
            }

            if (Employees.Count != 0)
            {
                SelectedEmployee = Employees[0];
            }

        }

    }
}
