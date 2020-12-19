using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GameBookkeeping
{
    class MainViewModel : INotifyPropertyChanged
    {
        private Employee _selectedEmployee;

        public ObservableCollection<Employee> Employees { get; private set; } = new ObservableCollection<Employee>();

        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            var employees = new DatabaseAccess().GetEmployees();

            foreach(Employee employee in employees)
            {
                Employees.Add(employee);
            }

            if(employees.Length != 0)
            {
                SelectedEmployee = employees[0];
            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
