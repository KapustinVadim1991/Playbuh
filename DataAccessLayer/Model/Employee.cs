using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace DataAccessLayer.Model
{
    [Table("Employee")]
    public class Employee
    {
        public Employee() { }

        public Employee(string firstName, string lastName, string middleName, string description)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Description = description;
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("middle_name")]
        public string MiddleName { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("archive")]
        public bool IsArchive { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
