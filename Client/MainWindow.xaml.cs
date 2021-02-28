using BLogic.Model;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Grid;
using Client.ViewModels;
using System.Windows;
using System;
using Client.Helpers;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Client
{
    public partial class MainWindow : ThemedWindow
    {
        private PlaybuhViewModel _viewModel;     

        public MainWindow()
        {
            InitializeComponent();

            _viewModel = new PlaybuhViewModel();

            DataContext = _viewModel;
        }

        private void addItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            DXTabItem dXTabItem = (DXTabItem)tabControl.SelectedItem;

            employeesTableView.AddNewRow();
            employeesTableView.MoveLastRow();
            employeesTableView.Focus();
            employeesTableView.ShowEditForm();
        }

        private void CreateNewRow(TableView tableView)
        {

        }

        private void employeesTableView_ValidateRow(object sender, DevExpress.Xpf.Grid.GridRowValidationEventArgs e)
        {

        }

        private void employeesTableView_RowUpdated(object sender, DevExpress.Xpf.Grid.RowEventArgs e)
        {
            try
            {
                if (e.Row is Employee employee)
                {
                    _viewModel.EmployeeAddOrUpdate(employee);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contragentsTableView_RowUpdated(object sender, RowEventArgs e)
        {
            try
            {
                if (e.Row is Contragent contragent)
                {
                    _viewModel.ContragentAddOrUpdate(contragent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
