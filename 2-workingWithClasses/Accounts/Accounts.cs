namespace Accounts
{
	class CheckingAccount
	{
		/*
			Quando uma propriedade é "static", ela passa a ser da classe, e não mais dos objetos criados a partir dela.
			Para acessar metodos, propriedades ou campos estaticos, é necessario referenciar a classe, e não o objeto. Ex.:
				CheckingAccount.CreatedAccountsAmount.
		*/
		public static int CreatedAccountsAmount { get; private set; }

		// Método construtor da classe.
		public CheckingAccount() {
			// Para acessar uma propriedade static (da classe), não se usa o "this", pois o this faz referência a instancia criada a partir da classe.
			++CreatedAccountsAmount;
		}
		// Usar prefixo "_" para campos private ou internal.
		// Os campos, diferente das variáveis ou contantes, possuem um valor padrão dependendo do tipo deles. Para tipos numericos, o valor padrão é 0.
		// Para string, o valor padrão é null, e para bool, o valor padrão é false.
		// Também é possível definir um outro valor padrão.
		private int _agencyCode;
		public int AgencyCode {
			get { return this._agencyCode; }
			set { this._agencyCode = value; }
		}
		private string _account = "0001";
		public string Account {
			get { return this._account; }
		}


		// Dessa forma, o campo owner é uma referências para objetos do tipo Client.
		private Clients.Client _owner;
		public Clients.Client Owner {
			get { return this._owner; }
			set { this._owner = value; }
		}

		private double _balance;
		public double Balance {
			get { return this._balance; }
			set
			{
				if (value > 0)
				{
					this._balance = value;
				}
			}
		}

		// Criação de métodos de classe;

		public void Deposit(double value)
		{
			// o this referencia a própria classe. Assim, é possível acessar seus próprios valores e métodos.
			this.Balance += value;
		}

		public void Withdraw(double value)
		{
			if (this.Balance >= value)
			{
				this.Balance -= value;
			}
			// Lançando um erro caso o valor de saque seja maior que o valor da carteira.
			else
			{
				throw new Exception("Erro: Saldo insufiente para realizar o saque.");
			}
		}

		public void Transfer(double value, CheckingAccount destinyAccount)
		{
			if (this.Balance >= value)
			{
				this.Withdraw(value);
				destinyAccount.Deposit(value);
			}
			else
			{
				throw new Exception("Erro: Saldo insuficiente para realizar a transferência.");
			}
		}
	}
}
