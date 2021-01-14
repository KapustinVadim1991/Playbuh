using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Windows.Documents;
using GameBookkeeping.ServicePlaybuh;

namespace GameBookkeeping
{
    class MainViewModel : INotifyPropertyChanged
    {
        private Employee1 _selectedEmployee;

        public ObservableCollection<Employee1> Employees { get; private set; } = new ObservableCollection<Employee1>();

        public Employee1 SelectedEmployee
        {
            get
            {
                return _selectedEmployee;
            }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            var service = new ServicePlaybuh.ServiceNetworkClient();

            Employee[] employees = service.GetEmployees(false);

            foreach (Employee employee in employees)
            {
                var str =  employee.ToString();
                Employees.Add(new Employee1
                    {
                        Id = employee.Id,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        MiddleName = employee.MiddleName,
                        IsArchive = employee.IsArchive,
                        Description = employee.Description
                    });
            }

            if (Employees.Count != 0)
            {
                SelectedEmployee = Employees[0];
            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
