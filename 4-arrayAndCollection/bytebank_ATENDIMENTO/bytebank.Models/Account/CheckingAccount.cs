namespace bytebank.Models.Account
{
	// Para utilizar o método sorte, a classe precisa implementar o método CompareTo, da interface IComparable.
	// OBS.: IComparable é uma classe genérica, sendo necessário passar para ela qual será o tipo a ser utilizado para realizar a comparação
	public class CheckingAccount : IComparable<CheckingAccount>
	{
		private int _agencyCode;

		private string _accountCode;

		private double _balance;

		public Client Owner { get; private set; }

		public string AgencyName { get; private set; }

		public int AgencyCode
		{
			get
			{
				return _agencyCode;
			}
			set
			{
				if (value > 0)
				{
					_agencyCode = value;
				}
				else
				{
					Console.WriteLine("Número da conta precisa ter ao menos três caracteres.");
				}
			}
		}

		public string AccountCode
		{
			get
			{
				return _accountCode;
			}
			set
			{
				if (value != null)
				{
					_accountCode = value;
				}
			}
		}

		public double Balance
		{
			get
			{
				return _balance;
			}
			set
			{
				if (!(value < 0.0))
				{
					_balance = value;
				}
			}
		}

		public static int CreatedAccountAmount { get; set; }

		public bool Withdraw(double value)
		{
			if (_balance < value)
			{
				return false;
			}
			if (value < 0.0)
			{
				return false;
			}
			_balance -= value;
			return true;
		}

		public void Deposit(double value)
		{
			if (!(value < 0.0))
			{
				_balance += value;
			}
		}

		public bool Transfer(double value, CheckingAccount destinyAccount)
		{
			if (_balance < value)
			{
				return false;
			}
			if (value < 0.0)
			{
				return false;
			}
			_balance -= value;
			destinyAccount._balance += value;
			return true;
		}

		public CheckingAccount(int agencyCode, string agencyName, bytebank.Models.Account.Client owner, double balance)
		{
			AgencyName = agencyName;
			_balance = balance;
			_agencyCode = agencyCode;
			_accountCode = Guid.NewGuid().ToString().Substring(0, 8);
			Owner = owner;
			
			++ CreatedAccountAmount;
		}

		public override string ToString()
		{

			return $" === DADOS DA CONTA === \n" +
				   $"Número da Agência : {this.AgencyCode} \n" +
				   $"Número da Conta : {this.AccountCode} \n" +
				   $"Titular da Conta: {this.Owner.Name} \n" +
				   $"CPF do Titular  : {this.Owner.Cpf} \n" +
				   $"Profissão do Titular: {this.Owner.Occupation} \n" +
				   $"Saldo atual: {this.Balance}";
		}

		/*
			Método CompareTo: passar como parametro o mesmo tipo passado na atribuição da interface a classe
			esse método espera retornar um int, e a partir desse retorno, realiza a ordenação na lista.
				int < 0 =  A instância precede o parametro na ordem de comparação;
				int 0 = Intância ocorre na mesma posição que o parametro na ordem de comparação;
				int > 0 = A instância segue o valor o parametro na ordem de comparação;
		*/
		public int CompareTo(CheckingAccount? comparisionAccount)
		{
			if (comparisionAccount == null)
			{
				return 1;
			}
			else {
				return this.AccountCode.CompareTo(comparisionAccount.AccountCode);
			}
		}
    }

}