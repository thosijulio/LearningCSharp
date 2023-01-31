namespace bytebank.Models.Administrative.Employees
{
    public class Diretor : AuthenticateEmployee
    {
        public Diretor(string cpf, string name, string password) : base(5000, cpf, name, password)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void RaiseSalary()
        {
            this.Salary *= 1.15;
        }

        public override double GetBonusAmount()
        {
            return this.Salary * 0.5;
        }
    }
}
