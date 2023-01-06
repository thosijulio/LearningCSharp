/*
	Curso de C#: Orientação a objeto (Alura).
	Neste curso, foi desenvolvido uma aplicação para o ByteBank, um banco digital fictício, sendo que o objetivo
	dessa aplicação será o controle de contas correntes dos clientes desse banco.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
	class CheckingAccount
	{
		// Usar prefixo "_" para campos private ou internal.
		// Os campos, diferente das variáveis ou contantes, possuem um valor padrão dependendo do tipo deles. Para tipos numericos, o valor padrão é 0.
		// Para string, o valor padrão é null, e para bool, o valor padrão é false.
		// Também é possível definir um outro valor padrão.
		public int agencyCode;
		public string account = "0001";
		public string owner = "";
		public double balance;

		// Criação de métodos de classe;

		public void Deposit(double value)
		{
			// o this referencia a própria classe. Assim, é possível acessar seus próprios valores e métodos.
			this.balance += value;
		}

		public void Withdraw(double value)
		{
			if (this.balance >= value)
			{
				this.balance -= value;
			}
			// Lançando um erro caso o valor de saque seja maior que o valor da carteira.
			else
			{
				throw new Exception("Erro: Saldo insufiente para realizar o saque.");
			}
		}

		public void Transfer(double value, CheckingAccount destinyAccount)
		{
			if (this.balance >= value)
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
