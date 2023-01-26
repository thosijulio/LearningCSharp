namespace Employees
{
	public class Manager : Employees.Employee
	{
		public string Password { get; set; } = "";
		public Manager(string name, string cpf, double salary) : base(name, cpf, salary){}

		public override double getBonus()
		{
			return this.Salary * 0.25;
		}

		public override void raiseSalary()
		{
			this.Salary *= 1.05;
		}

		public bool Authenticate(string password)
        {
            return this.Password == password;
        }
	}
}