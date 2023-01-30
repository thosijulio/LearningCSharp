Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void TestCheckingAccountList()
{
    bytebank.Utils.CheckingAccountList accountsList = new bytebank.Utils.CheckingAccountList();
    
    accountsList.AddAccount(new bytebank.Models.Account.CheckingAccount(0001, "Bytebank", new bytebank.Models.Account.Client("159762438-10", "Lilian Souza", "Cozinheira"), "6635-X", 583.25));
    accountsList.AddAccount(new bytebank.Models.Account.CheckingAccount(0001, "Bytebank", new bytebank.Models.Account.Client("159762438-10", "Clovis Machonici", "Ator"), "6635-X", 16.48));
    accountsList.AddAccount(new bytebank.Models.Account.CheckingAccount(0001, "Bytebank", new bytebank.Models.Account.Client("159762438-10", "Aline Moura", "Atriz"), "6635-X", 1520.10));
    accountsList.AddAccount(new bytebank.Models.Account.CheckingAccount(0001, "Bytebank", new bytebank.Models.Account.Client("159762438-10", "Brendo Oliveira", "Tradutor"), "6635-X", 795.41));
    accountsList.AddAccount(new bytebank.Models.Account.CheckingAccount(0001, "Bytebank", new bytebank.Models.Account.Client("159762438-10", "Carolina Silva", "Desenvolvedora"), "6635-X", 198.77));

    Console.WriteLine(accountsList.getAccountWithGreaterBalance());
}

TestCheckingAccountList();
