namespace bytebank.Models.Administrative.Utils
{
    public class BonusManager
    {
        private double _totalBonus;

        public void Register(bytebank.Models.Administrative.Employees.Employee employee)
        {
            _totalBonus += employee.GetBonusAmount();
        }

        public double GetBonusAmount()
        {
            return _totalBonus;
        }

    }
}
