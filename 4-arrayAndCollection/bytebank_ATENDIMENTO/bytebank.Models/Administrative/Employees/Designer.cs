
namespace bytebank.Models.Administrative.Employees
{
    public class Designer : Employee
    {
        public Designer(string cpf, string name) : base(3000, cpf, name){}

        public override void RaiseSalary()
        {
            this.Salary *= 1.11;
        }

        public override double GetBonusAmount()
        {
            return this.Salary * 0.17;
        }
    }
}
