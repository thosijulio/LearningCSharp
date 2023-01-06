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
		public int agencyCode = 0;
		public string account = "";
		public string owner = "";
		public double balance = 1200;
	}
}