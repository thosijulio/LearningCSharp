
namespace bytebank.Models.Administrative.Employees
{
    public abstract class Employee
    {
        public static int TotalEmployees { get; private set; }

        public string Name { get; set; }
        public string Cpf { get; private set; }
        public double Salary { get; protected set; }

        public Employee(double salario, string cpf, string name)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            this.Cpf = cpf;
            this.Salary = salario;
            this.Name = name;

            ++ TotalEmployees;
        }

        public abstract void RaiseSalary();

        public abstract double GetBonusAmount();
    }
}
