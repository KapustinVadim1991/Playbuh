using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using BLogic.Model;
using Client.PlaybuhService;
using DevExpress.Mvvm;

namespace Client.ViewModels
{
    public class ViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public ViewModel()
        {
            Initialize();
        }

        private Employee _selectedEmployee;

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }

        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>();

        public event PropertyChangedEventHandler PropertyChanged;

        private void Initialize()
        {
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
        
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void EmployeeUpdate(Employee employee)
        {
            var service = new ServiceNetworkClient();
            if(employee.Id == 0)
            {
                int newEmployeeId = service.AddEmployee(employee.FirstName, employee.LastName, employee.MiddleName, employee.Description);
                employee.Id = newEmployeeId;
            }
            else
            {
                service.ChangeEmployeeFullName(employee.Id, employee.FirstName, employee.LastName, employee.MiddleName, employee.Description);
            }
        }
    }
}