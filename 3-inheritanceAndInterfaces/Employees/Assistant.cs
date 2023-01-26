namespace Employees
{
    public class Assistant : Employees.Employee
	{
		public Assistant(string name, string cpf, double salary) : base(name, cpf, salary){}

		public override double getBonus()
		{
			return this.Salary * 0.2;
		}

		public override void raiseSalary()
		{
			this.Salary *= 1.1;
		}
	}
}