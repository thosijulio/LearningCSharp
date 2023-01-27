namespace Employees
{

	/*
		Para definir um contrato com uma interface em uma classe, basta inserir da mesma maneira que é feito
		com uma classe pai, dois pontos após a declaração e a interface. Caso exista uma classe pai, colocar virgula, e a interface.
		Dessa forma, a classe Manager tem a obrigação de criar uma implementação para tudo que exista em IAuthentication.
	*/
	public class Manager : Employees.Employee, InternalSystem.IAuthentication
	{
        public string Password { get; set; }

        public Manager(string name, string cpf, double salary, string password) : base(name, cpf, salary){
			this.Password = password;
		}

		public override double getBonus()
		{
			return this.Salary * 0.25;
		}

		public override void raiseSalary()
		{
			this.Salary *= 1.05;
		}
	}
}