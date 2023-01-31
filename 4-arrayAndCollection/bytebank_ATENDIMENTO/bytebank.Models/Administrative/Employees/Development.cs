namespace bytebank.Models.Administrative.Employees
{
    public class Development : Employee
    {
        public Development(string cpf, string name) : base(3000, cpf, name){}

        public override void RaiseSalary()
        {
            this.Salary *= 0.15;
        }

        public override double GetBonusAmount()
        {
            return this.Salary * 0.1;
        }
    }
}
