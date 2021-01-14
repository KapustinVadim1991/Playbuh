namespace GameBookkeeping
{
    public class Employee1
    {
        public Employee1() { }

        public Employee1(string firstName, string lastName, string middleName, string description = null)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Description = description;
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
