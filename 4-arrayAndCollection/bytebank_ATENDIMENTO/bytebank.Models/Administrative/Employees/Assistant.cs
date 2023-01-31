namespace bytebank.Models.Administrative.Employees
{
    public class Assistant : Employee
    {
        public Assistant(string cpf, string name) : base(2000, cpf, name){}

        public override void RaiseSalary()
        {
            Salary *= 1.1;
        }

        public override double GetBonusAmount()
        {
            return Salary * 0.2;
        }
    }
}
