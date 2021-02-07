using BLogic.Model;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Bars;
using Client.ViewModels;

namespace Client
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        private ViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();

            _viewModel = new ViewModel();

            DataContext = _viewModel;
        }

        private void addItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            employeesTableView.AddNewRow();
            employeesTableView.MoveLastRow();
            employeesTableView.Focus();
            employeesTableView.ShowEditForm();
        }

        private void employeesTableView_ValidateRow(object sender, DevExpress.Xpf.Grid.GridRowValidationEventArgs e)
        {

        }

        private void employeesTableView_RowUpdated(object sender, DevExpress.Xpf.Grid.RowEventArgs e)
        {
            if (e.Row is Employee employee)
                _viewModel.EmployeeUpdate(employee);
        }
    }
}
