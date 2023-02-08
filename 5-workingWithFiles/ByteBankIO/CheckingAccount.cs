namespace ByteBankIO
{
    public class CheckingAccount
    {
        public int AccountCode { get; private set; }
        public string AgencyName { get; private set; }
        public double Balance { get; private set; }
        public Client Owner { get; private set; }

        public CheckingAccount(int accountCode, string agencyName, double balance, Client owner)
        {
            AccountCode = accountCode;
            AgencyName = agencyName;
            Balance = balance;
            Owner = owner;
        }

        public void Deposit(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Valor de deposito deve ser maior que zero.", nameof(value));
            }

            Balance += value;
        }

        public void Withdraw(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Valor de saque deve ser maior que zero.", nameof(value));
            }

            if (value > Balance)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }

            Balance += value;
        }

        public override string ToString()
        {
            // @$"" = string literal com multiplas linhas.
            return @$"
Nº da conta: {this.AccountCode}
Nome da agência: {this.AgencyName}
Saldo na conta: {this.Balance}
Nome do cliente: {this.Owner.Name}";
        }
    }
}
