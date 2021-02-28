using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using BLogic.Model;
using Client.PlaybuhService;
using DevExpress.Mvvm;

namespace Client.ViewModels
{
    public class PlaybuhViewModel : ViewModelBase
    {
        private ServiceNetworkClient _serviceNetwork;

        private Employee _selectedEmployee;
        private Contragent _selectedContragent;

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                _selectedEmployee = value;
                RaisePropertiesChanged("SelectedEmployee");
            }
        }
        public Contragent SelectedContragent
        {
            get => _selectedContragent;
            set
            {
                _selectedContragent = value;
                RaisePropertiesChanged("SelectedContragent");
            }
        }

        public List<Employee> Employees { get; set; }
        public List<Contragent> Contragents { get; set; }

        public bool IsShowArchive { get; set; }

        public PlaybuhViewModel()
        {
            try
            {
                _serviceNetwork = new ServiceNetworkClient();

                RefreshEmployeesTableView();
                RefreshContragentsTableView();
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}{Environment.NewLine}{e.InnerException}{Environment.NewLine}{e.StackTrace}");
            }
        }

        /// <summary>
        /// Обновление списка сотрудников.
        /// </summary>
        private void RefreshEmployeesTableView()
        {
            Employees = _serviceNetwork.GetEmployees(IsShowArchive).ToList();

            if (Employees.Count > 0)
            {
                SelectedEmployee = Employees[0];
            }
        }

        /// <summary>
        /// Обновление списка контрагентов.
        /// </summary>
        private void RefreshContragentsTableView()
        {
            Contragents = _serviceNetwork.GetContragents(IsShowArchive).ToList();

            if (Contragents.Count > 0)
            {
                SelectedContragent = Contragents[0];
            }
        }

        /// <summary>
        /// Добавление или обновление данных сотрудника
        /// </summary>
        /// <param name="employee"></param>
        public void EmployeeAddOrUpdate(Employee employee)
        {
            if (employee.Id == 0)
            {
                _serviceNetwork.AddEmployee(employee.FirstName, employee.LastName, employee.MiddleName, employee.Description);
            }
            else
            {
                _serviceNetwork.ChangeEmployeeFullName(employee.Id, employee.FirstName, employee.LastName, employee.MiddleName, employee.Description);
            }

            RefreshEmployeesTableView();
        }

        /// <summary>
        /// Добавление или обновление данных контрагента
        /// </summary>
        /// <param name="contragent"></param>
        public void ContragentAddOrUpdate(Contragent contragent)
        {
            if (contragent.Id == 0)
            {
                _serviceNetwork.AddContragent(contragent.Title, contragent.Comment);
            }
            else
            {
                _serviceNetwork.ChangeContragentData(contragent.Id, contragent.Title, contragent.Comment);
            }

            RefreshEmployeesTableView();
        }
    }
}