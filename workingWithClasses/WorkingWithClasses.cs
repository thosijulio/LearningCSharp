using bytebank;

// Criação de uma instância (obj) da classe CheckingAccount.
CheckingAccount brunoAccount = new CheckingAccount();
CheckingAccount laraAccount = new CheckingAccount();

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
CheckingAccount exampleDuplicateAccount = brunoAccount;

// Acessando os campos públicos criados na classe com interpolação de string;
Console.WriteLine($"Saldo da conta antes do deposito: R${brunoAccount.balance}");

brunoAccount.Deposit(150.40);
brunoAccount.owner = "Bruno";
laraAccount.owner = "Lara";

Console.WriteLine($"Saldo da conta do {brunoAccount.owner} após do deposito: R${brunoAccount.balance}");

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
    Console.WriteLine($"Saldo na conta da lara antes da transferência: R${laraAccount.balance}. Saldo na conta do Bruno antes da transferência: R${brunoAccount.balance}");
    brunoAccount.Transfer(valueToTransfer, laraAccount);
    Console.WriteLine($"Saldo na conta da lara após a transferência: R${laraAccount.balance}. Saldo na conta do Bruno após a transferência: R${brunoAccount.balance}");
}
catch (System.Exception error)
{
    Console.WriteLine(error.Message);
}


Console.WriteLine($"Saldo na conta após todas as operações: {brunoAccount.balance}");