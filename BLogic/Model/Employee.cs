using DevExpress.Mvvm;
using System.ComponentModel.DataAnnotations;

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

        [Display(AutoGenerateField = false)]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(AutoGenerateField = false)]
        public bool IsArchive { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
