using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using GameBookkeeping.ServicePlaybuh;
using Employee = BLogic.Model.Employee;

namespace GameBookkeeping
{
    class MainViewModel : INotifyPropertyChanged
    {
        private Employee _selectedEmployee;

        public Employee[] Employees { get; set; }

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

        public MainViewModel()
        {
            Initialize();



        }

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


        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private void LoadEmployees(ServiceNetworkClient service)
        {
            Employees = service.GetEmployees(false);


            if (Employees.Length != 0)
            {
                SelectedEmployee = Employees[0];
            }
        }
    }
}
