Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exercícios com Array e indexadores de classe C#
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
# endregion


/*
    ArrayList biblioteca de System.Collections que provê métodos para manuseio de um vetor.

    Vantagens:
    O tamanho do array é dinamico, nao sendo necessário criar uma classe para aumentar e inserir valores ao fim do array, como no exemplo anterior
    Desvantagens:
    Seu uso é depreciado por questões performáticas. A microsoft recomenda utilizar List<T>.
*/
System.Collections.ArrayList _accountList = new System.Collections.ArrayList();

void RegisterAccount()
{
    Console.Clear();
    Console.WriteLine("======================================================\n");
    Console.WriteLine("                  ------------------                  ");
    Console.WriteLine("=====             Cadastro de Contas             =====");
    Console.WriteLine("                  ------------------                  ");
    Console.WriteLine("\n=====  Informe os dados para criação de conta:  =====\n");

    try
    {
        Console.Write("CPF do cliente: ");
        string ownerCpf = Console.ReadLine();
        Console.Write("Nome do cliente: ");
        string ownerName = Console.ReadLine();
        Console.Write("Profissão do cliente: ");
        string ownerOccupation = Console.ReadLine();

        bytebank.Models.Account.Client client = new bytebank.Models.Account.Client(ownerCpf, ownerName, ownerOccupation);

        Console.Write("Nome da agência: ");
        string agencyName = Console.ReadLine();
        Console.Write("Número da agência: ");
        string accountCode = Console.ReadLine();
        Console.Write("Número da conta: ");
        int agencyCode = int.Parse(Console.ReadLine());
        Console.Write("Saldo inicial na conta: ");
        double balance = double.Parse(Console.ReadLine());
        
        bytebank.Models.Account.CheckingAccount account = new bytebank.Models.Account.CheckingAccount(agencyCode, agencyName, client, accountCode, balance);

        _accountList.Add(account);
        Console.WriteLine("             ----------------------------             ");
        Console.WriteLine("             Conta cadastrada com sucesso             ");
        Console.WriteLine("             ----------------------------             ");
    }
    catch (System.Exception)
    {
        Console.WriteLine("\nERRO: Dados inválidos. Tente novamente.");
    }
}

void ShowAccounts()
{
    if (_accountList.Count <= 0)
    {
        Console.WriteLine("Nenhuma conta cadastrada.");
    }
    else
    {
        foreach(bytebank.Models.Account.CheckingAccount account in _accountList)
        {
            Console.WriteLine(account);
        }
    }
}

void CustomerService()
{
    char option = '0';
    while (option != '6')
    {
        #region Iteração inicial com o usuário via console
        Console.Clear();
        Console.WriteLine("======================================================\n");
        Console.WriteLine("                ----------------------                ");
        Console.WriteLine("=====           Central de Atendimento           =====");
        Console.WriteLine("                ----------------------                ");
        Console.WriteLine("\n=====     Digite o número da opção desejada:     =====");
        Console.WriteLine("=====             1: Cadastrar conta             =====");
        Console.WriteLine("=====              2: Listar contas              =====");
        Console.WriteLine("=====        3: Remover conta pelo índice        =====");
        Console.WriteLine("=====              4: Ordenar conta              =====");
        Console.WriteLine("=====             5: Pesquisar conta             =====");
        Console.WriteLine("=====            6: Sair da aplicação            =====");
        Console.WriteLine("\n======================================================\n\n");
        Console.Write("Opção: ");
        
        char selectedOption = Console.ReadLine()[0];
        #endregion

        if (char.IsNumber(selectedOption))
        {
            option = selectedOption;
        }
        else
        {
            Console.WriteLine("=======    Opção inválida. Tente novamente.    =======");
        }

        switch (option)
        {
            case '1':
                RegisterAccount();
                break;
            case '2':
                ShowAccounts();
                break;
            case '3':
                break;
            case '4':
                break;
            case '5':
                break;
            case '6':
                return;
            default:
                Console.WriteLine("Opção não implementada.");
                break;
        }


        Console.WriteLine("\nPressione X para fechar a aplicação ou qualquer outra tecla para continuar.");
        Console.Write("Opção: ");
        char exitOption = Console.ReadLine()[0];
        if (exitOption == 'X') break;
    }
}

CustomerService();
Console.WriteLine("======================================================");
Console.WriteLine("=====               Fim da sessão.               =====");
Console.WriteLine("======================================================\n");