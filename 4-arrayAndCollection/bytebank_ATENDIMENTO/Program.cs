Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void TestCheckingAccountList()
{
    bytebank.Models.Administrative.Utils.CheckingAccountList accountsList = new bytebank.Models.Administrative.Utils.CheckingAccountList();

    bytebank.Models.Account.Client carolina = new bytebank.Models.Account.Client("345.694.233-50", "Carolina da Silva", "Desenvolvedora");
    bytebank.Models.Account.CheckingAccount carolinaAccount = new bytebank.Models.Account.CheckingAccount(0001, "Bytebank", carolina, "6635-X", 583.25);

    bytebank.Models.Account.Client lilian = new bytebank.Models.Account.Client("345.694.233-50", "Lilian Souza", "Cozinheira");
    bytebank.Models.Account.CheckingAccount lilianAccount = new bytebank.Models.Account.CheckingAccount(0001, "Bytebank", lilian, "6635-X", 16.48);

    bytebank.Models.Account.Client clovis = new bytebank.Models.Account.Client("345.694.233-50", "Clovis Machonici", "Taxista");
    bytebank.Models.Account.CheckingAccount clovisAccount = new bytebank.Models.Account.CheckingAccount(0001, "Bytebank", clovis, "6635-X", 1520.10);

    bytebank.Models.Account.Client aline = new bytebank.Models.Account.Client("345.694.233-50", "Aline Moura", "Atriz");
    bytebank.Models.Account.CheckingAccount alineAccount = new bytebank.Models.Account.CheckingAccount(0001, "Bytebank", aline, "6635-X", 795.41);

    accountsList.AddAccount(carolinaAccount);
    accountsList.AddAccount(lilianAccount);
    accountsList.AddAccount(clovisAccount);
    accountsList.AddAccount(alineAccount);

    Console.WriteLine(accountsList.GetAccountWithGreaterBalance());

    accountsList.ShowAccounts();
    accountsList.DeleteAccount(carolinaAccount);
    accountsList.DeleteAccount(carolinaAccount);
    accountsList.ShowAccounts();
    accountsList.AddAccount(carolinaAccount);
    accountsList.ShowAccounts();

    Console.WriteLine(accountsList[1]);
}

TestCheckingAccountList();
