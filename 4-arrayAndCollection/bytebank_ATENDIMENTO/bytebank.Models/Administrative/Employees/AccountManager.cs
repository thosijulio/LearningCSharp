namespace bytebank.Models.Administrative.Employees
{
    public class AccountManager : AuthenticateEmployee
    {
        public AccountManager(string cpf, string name, string password) : base(4000, cpf, name, password)
        {
        }

        public override void RaiseSalary()
        {
            this.Salary *= 1.05;
        }

        public override double GetBonusAmount()
        {
            return this.Salary * 0.25;
        }
    }
}
