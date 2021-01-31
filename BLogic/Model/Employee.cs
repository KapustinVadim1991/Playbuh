using DevExpress.Mvvm;

namespace BLogic.Model
{
    public class Employee : BindableBase
    {
        public Employee() { }

        public Employee(DataAccessLayer.Model.Employee employee)
        {
            Id = employee.Id;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            MiddleName = employee.MiddleName;
            Description = employee.Description;
            IsArchive = employee.IsArchive;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Description { get; set; }

        public bool IsArchive { get; set; }
        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
