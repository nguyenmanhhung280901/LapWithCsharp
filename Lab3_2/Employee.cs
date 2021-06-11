namespace Lab3_2
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string address;
        private long sin;
        private double salary;

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;   
        }

        public override string ToString()
        {
            return $"First name: {firstName}, Last name: {lastName}, Address: {address}, Sin: {sin}, Salary: {salary}";
        }

        public double CalculateTheBonus(double percentage)
        {
            return salary * percentage;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public long Sin
        {
            get => sin;
            set => sin = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }
    }
}