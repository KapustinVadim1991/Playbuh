//using System;
//using System.Collections.ObjectModel;
//using System.ComponentModel;
//using System.Runtime.CompilerServices;
//using System.Windows;
//using BLogic.Model;
//using Client.PlaybuhService;
//using DevExpress.Mvvm;
//using System.Linq;

//namespace Client.ViewModels
//{
//    public class ViewModel : ViewModelBase, INotifyPropertyChanged
//    {
//        private Employee _selectedEmployee;

//        public ObservableCollection<Employee> Employees { get; set; }

//        public Employee SelectedEmployee
//        {
//            get => _selectedEmployee;
//            set
//            {
//                _selectedEmployee = value;
//                OnPropertyChanged("SelectedEmployee");
//            }
//        }

//        public event PropertyChangedEventHandler PropertyChanged;

//        public ViewModel()
//        {
//            Initialize();
//        }

//        private void Initialize()
//        {
//            try
//            {
//                var service = new ServiceNetworkClient();

//                LoadEmployees(service);


//            }
//            catch (Exception e)
//            {
//                MessageBox.Show($"{e.Message}\n{e.InnerException}\n{e.StackTrace}");
//            }
//        }


//        public void OnPropertyChanged([CallerMemberName]string prop = "")
//        {
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
//        }

//        private void LoadEmployees(ServiceNetworkClient service)
//        {
//            var employees = service.GetEmployees(false);

//            foreach(var emp in employees)
//            {
//                Employees.Add(emp);
//            }

//            if (Employees.Count != 0)
//            {
//                SelectedEmployee = Employees[0];
//            }
//        }

//    }
//}