/*
	Curso de C#: Orientação a objeto (Alura).
	Neste curso, foi desenvolvido uma aplicação para o ByteBank, um banco digital fictício, sendo que o objetivo
	dessa aplicação será o controle de contas correntes dos clientes desse banco.
*/

// Criação de uma instância da classe Usuário para realizar a composição com a classe CheckingAccount;
// Ao invés de utilizar no começo do arquivo "use bytebank", optei por deixar explicito de onde está "vindo" cada classe.
// Dessa maneira, o código fica um pouco mais extenso, porém mais fácil de compreender.

Clients.Client bruno = new Clients.Client("123456789-10", "Bruno", "Analista");
Clients.Client lara = new Clients.Client("456789123-10", "Lara", "Desenvolvedora");

// Criação de uma instância (obj) da classe CheckingAccount.
Accounts.CheckingAccount brunoAccount = new Accounts.CheckingAccount();
Accounts.CheckingAccount laraAccount = new Accounts.CheckingAccount();

// Realizando a composição
brunoAccount.Owner = bruno;
laraAccount.Owner = lara;

/*
    Comparação por valor e por referência.
        Comparação por valor:
            Usado em tipos primitivos. Ex.: int 5 == int 6; "julio" == "Juliooo";
        Comparação por referência:
            Usado quando usamos o operador "new" para criar uma instancia de um tipo (classe).
            Nesses casos, o resultado de uma comparação entre esses tipos só será verdadeiro quando:
                As duas variáveis fizerem referência a mesma instancia (ex.: brunoAccount e exampleDuplicateAccount).
                Do contrario (brunoAccount e laraAccount), por mais que todos os métodos e valores sejam exatamente iguais,
                o resultado da comparação sempre resultará em false, pois as duas apontam referências diferentes na memória.
*/

// Todas as alterações feitas em brunoAccount serão feitas aqui, e vice versa, pois as referências apontam para o mesmo objeto.
Accounts.CheckingAccount exampleDuplicateAccount = brunoAccount;

// Acessando os campos públicos criados na classe com interpolação de string;
Console.WriteLine($"Saldo da conta antes do deposito: R${brunoAccount.Balance}");

brunoAccount.Deposit(150.40);

Console.WriteLine($"Saldo da conta do {brunoAccount.Owner} após do deposito: R${brunoAccount.Balance}");

double valueToWithdraw = 50.69;
double valueToTransfer = 67.90;

// Lidando com a exceção lançada ao tentar realizar um saque maior que o valor existente em conta.
try
{
    brunoAccount.Withdraw(valueToWithdraw);
    Console.WriteLine($"Saque no valor de {valueToWithdraw} realizado com sucesso!");
}
catch (System.Exception error)
{
    Console.WriteLine(error.Message);
}

try
{
    Console.WriteLine($"Saldo na conta da {laraAccount.Owner.Name} antes da transferência: R${laraAccount.Balance}. Saldo na conta do {brunoAccount.Owner.Name} antes da transferência: R${brunoAccount.Balance}");
    brunoAccount.Transfer(valueToTransfer, laraAccount);
    Console.WriteLine($"Saldo na conta da {laraAccount.Owner.Name} após a transferência: R${laraAccount.Balance}. Saldo na conta do {brunoAccount.Owner.Name} após a transferência: R${brunoAccount.Balance}");
}
catch (System.Exception error)
{
    Console.WriteLine(error.Message);
}


Console.WriteLine($"Saldo na conta após todas as operações: {brunoAccount.Balance}");