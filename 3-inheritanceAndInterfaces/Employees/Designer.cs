namespace Employees
{
    public class Designer : Employees.Employee
    {
        public Designer(string name, string cpf, double salary) : base(name, cpf, salary){}

        public override double getBonus()
        {
            return this.Salary * 0.17;
        }
        public override void raiseSalary()
        {
            this.Salary *= 1.11;
        }
    }
}