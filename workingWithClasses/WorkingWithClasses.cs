/*
	Curso de C#: Orientação a objeto (Alura).
	Neste curso, foi desenvolvido uma aplicação para o ByteBank, um banco digital fictício, sendo que o objetivo
	dessa aplicação será o controle de contas correntes dos clientes desse banco.
*/

// Criação de uma instância da classe Usuário para realizar a composição com a classe CheckingAccount;
// Ao invés de utilizar no começo do arquivo "use bytebank", optei por deixar explicito de onde está "vindo" cada classe.
// Dessa maneira, o código fica um pouco mais extenso, porém mais fácil de compreender.

Clients.Client bruno = new Clients.Client();
Clients.Client lara = new Clients.Client();

bruno.SetName("Bruno");
bruno.SetCpf("123456789-10");
bruno.SetOccupation("Analista");

lara.SetName("Lara");
lara.SetCpf("456789123-10");
lara.SetOccupation("Dev");

// Criação de uma instância (obj) da classe CheckingAccount.
Accounts.CheckingAccount brunoAccount = new Accounts.CheckingAccount();
Accounts.CheckingAccount laraAccount = new Accounts.CheckingAccount();

// Realizando a composição
brunoAccount.SetOwner(bruno);
laraAccount.SetOwner(lara);

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
Console.WriteLine($"Saldo da conta antes do deposito: R${brunoAccount.GetBalance()}");

brunoAccount.Deposit(150.40);

Console.WriteLine($"Saldo da conta do {brunoAccount.GetOwner()} após do deposito: R${brunoAccount.GetBalance()}");

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
    Console.WriteLine($"Saldo na conta da {laraAccount.GetOwner().GetName()} antes da transferência: R${laraAccount.GetBalance()}. Saldo na conta do {brunoAccount.GetOwner().GetName()} antes da transferência: R${brunoAccount.GetBalance()}");
    brunoAccount.Transfer(valueToTransfer, laraAccount);
    Console.WriteLine($"Saldo na conta da {laraAccount.GetOwner().GetName()} após a transferência: R${laraAccount.GetBalance()}. Saldo na conta do {brunoAccount.GetOwner().GetName()} após a transferência: R${brunoAccount.GetBalance()}");
}
catch (System.Exception error)
{
    Console.WriteLine(error.Message);
}


Console.WriteLine($"Saldo na conta após todas as operações: {brunoAccount.GetBalance()}");