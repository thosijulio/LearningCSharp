namespace Employees
{
    class Employee {
        public Employee(string name, string cpf, double salary)
        {
            Name = name;
            Cpf = cpf;
            Salary = salary;
        }

        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public double Salary { get; private set; }

        public double getTwentyPercentOfSalary() {
            return Salary * 0.20;
        }
    }

}
