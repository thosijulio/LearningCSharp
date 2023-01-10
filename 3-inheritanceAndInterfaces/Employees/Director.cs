namespace Employees
{
    public class Director
    {
        public Director(string name, string cpf, double salary)
        {
            this.Name = name;
            this.Cpf = cpf;
            this.Salary = salary;
        }

        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public double Salary { get; private set; }

        public double getBonus()
        {
            return Salary * 1;
        }
    }
}