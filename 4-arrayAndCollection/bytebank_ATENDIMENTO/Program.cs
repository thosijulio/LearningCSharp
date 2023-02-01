﻿Console.Clear();
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.\n\n");

/*
    System.Collections.ArrayList _accountList = new System.Collections.ArrayList(); SUBSTITUIDO POR List<T>
    ArrayList: classe do namespace System.Collections. Implementação evoluída de um array que provê métodos para manuseio de um vetor.

    Vantagens:
    O tamanho do array é dinamico, nao sendo necessário criar uma classe para aumentar e inserir valores ao fim do array, como no exemplo anterior.
    A classe já disponibiliza operações de adição, inserção e exclusão de elementos.
    Desvantagens:
    Seu uso é depreciado por questões performáticas. A microsoft recomenda utilizar List<T>.

    Uma característica importate é a possibilidade de se adicionar qualquer tipo de elemento, uma vez que ela trabalha com tipo da superclasse object de qual
    todos os tipos do c# derivem
*/

/*
    dessa nova forma, utilizando List<T>, nós conseguimos criar um array com os mesmos métodos que ArrayList possuia, porém obrigando cada item a ser do tipo declarado,
    além de melhorar a performance.
    List é uma classe generica, ou seja, quando vamos cria-la, podemos passar o tipo pra ela. Exemplo de criação de classe generica no fim desse arquivo.
*/
List<bytebank.Models.Account.CheckingAccount> _accountList = new List<bytebank.Models.Account.CheckingAccount>();

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
        Console.WriteLine("======================================================\n");
    }
    catch (System.Exception)
    {
        Console.WriteLine("\nERRO: Dados inválidos. Tente novamente.");
    }
}

void ShowAccounts()
{
    Console.Clear();
    Console.WriteLine("======================================================\n");
    Console.WriteLine("                  ------------------                  ");
    Console.WriteLine("=====             Listagem de Contas             =====");
    Console.WriteLine("                  ------------------                  ");

    if (_accountList.Count <= 0)
    {
        Console.WriteLine("\nNenhuma conta cadastrada.");
    }
    else
    {
        foreach(bytebank.Models.Account.CheckingAccount account in _accountList)
        {
            Console.WriteLine(account);
        }
    }
}

void RemoveAccount()
{
    Console.Clear();
    Console.WriteLine("======================================================\n");
    Console.WriteLine("                  ------------------                  ");
    Console.WriteLine("=====             Exclusão de contas             =====");
    Console.WriteLine("                  ------------------                  ");
    Console.WriteLine("\n=====  Informe os dados para criação de conta:  =====\n");

    try
    {
        Console.Write("Digite o numero da conta a ser excluída: ");
        string accountCode = Console.ReadLine();

        bytebank.Models.Account.CheckingAccount accountToRemove = null;

        foreach(bytebank.Models.Account.CheckingAccount account in _accountList)
        {
            if (account.AccountCode == accountCode) accountToRemove = account;
        }
        if (accountToRemove == null)
        {
            Console.WriteLine("Conta não existe na lista.");
        }
        else
        {
            Console.WriteLine(accountToRemove);
            Console.WriteLine("              --------------------------              ");
            Console.WriteLine("              Conta excluída com sucesso              ");
            Console.WriteLine("              --------------------------              ");
            Console.WriteLine("======================================================\n");
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("\nERRO: Número inválidos. Tente novamente.");
    }
}

void CustomerService()
{
    char option = '0';
    while (option != '6')
    {
        #region Iteração inicial com o usuário via console
        Console.WriteLine("======================================================\n");
        Console.WriteLine("                ----------------------                ");
        Console.WriteLine("=====           Central de Atendimento           =====");
        Console.WriteLine("                ----------------------                ");
        Console.WriteLine("\n=====     Digite o número da opção desejada:     =====");
        Console.WriteLine("=====             1: Cadastrar conta             =====");
        Console.WriteLine("=====              2: Listar contas              =====");
        Console.WriteLine("=====              3: Remover conta              =====");
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
                RemoveAccount();
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
        try
        {
            char exitOption = Console.ReadLine()[0];
            if (exitOption == 'X')
            {
                Console.WriteLine("======================================================");
                Console.WriteLine("=====               Fim da sessão.               =====");
                Console.WriteLine("======================================================\n");
                break;
            }   
        }
        catch (System.Exception)
        {
            return;
        }
    }
}

CustomerService();


#region Estudos da classe generica List<T>
void findNameInListChallenge(List<string> list, string searchName)
{
    // Contains: Método que procura o valor passado por parametro na List instanciada e retorna um bool como resultado.
    if (list.Contains(searchName))
    {
        Console.WriteLine($"O nome {searchName} existe na lista.");
    }
    else
    {
        Console.WriteLine($"O nome {searchName} não existe na lista.");
    }
}

// findNameInListChallenge(new List<string>{"Joao", "Maria", "Bruna"}, "Bruna");
// findNameInListChallenge(new List<string>{"Joao", "Maria", "Bruna"}, "Rodrigo");

void genericListExamples()
{
    List<bytebank.Models.Account.CheckingAccount> _accountList2 = new List<bytebank.Models.Account.CheckingAccount>()
    {
        new bytebank.Models.Account.CheckingAccount(123, "Bytebank 1", new bytebank.Models.Account.Client("456", "Joao", "Dev"), "3211", 20),
        new bytebank.Models.Account.CheckingAccount(231, "Bytebank 2", new bytebank.Models.Account.Client("563", "Pedro", "Zelador"), "2112", 50),
        new bytebank.Models.Account.CheckingAccount(321, "Bytebank 3", new bytebank.Models.Account.Client("446", "Otavio", "Auxiliar"), "2312", 200.50),
    };
    List<bytebank.Models.Account.CheckingAccount> _accountList3 = new List<bytebank.Models.Account.CheckingAccount>()
    {
        new bytebank.Models.Account.CheckingAccount(14234, "Bytebank 4", new bytebank.Models.Account.Client("039578", "Anteteguemon", "Radialista"), "2571", 2198.46),
        new bytebank.Models.Account.CheckingAccount(57346, "Bytebank 5", new bytebank.Models.Account.Client("204897", "Olaria", "Atleta"), "2938", 23.47),
        new bytebank.Models.Account.CheckingAccount(21394, "Bytebank 6", new bytebank.Models.Account.Client("103954", "Maria", "Cozinheiro"), "9038", 1093.57),
    };

    // ADDLIST: método da classe List que adiciona ao fim do array os itens da lista passada por parametro.
    _accountList2.AddRange(_accountList3);

    // GETRANGE: método que retorna uma nova lista a partir da lista instanciada, com itens a partir do index passado como primeiro parametro, e a quantidade a partir dele passado no segundo.
    List<bytebank.Models.Account.CheckingAccount> getRangeExample = _accountList3.GetRange(0, 1);

    // REVERSE: método que inverte a ordem do List instanciada.
    _accountList2.Reverse();

    // CLEAR: método que remove todos os itens de uma List<>.
    _accountList2.Clear();

    Console.WriteLine("GetRange example");
    foreach (bytebank.Models.Account.CheckingAccount account in getRangeExample)
    {
        Console.WriteLine(account);
    }
    
    Console.WriteLine("AddRange/Reverse Example");
    foreach (bytebank.Models.Account.CheckingAccount account in _accountList2)
    {
        Console.WriteLine(account);
    }
}
#endregion

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

#region Estudo de classes Generics
/*
    GENERICS:
        Recurso da linguagem C# que permite personalizar métodos, classes, interfaces e estruturas,
        podendo diminuir código e maximizar o desempenho de uma aplicação, proporcionando uma segurança
        de tipos.
        Com generics, é possível deixar a definição do tipo para o momento que precisamos de determinado elemento no código,
        ou seja, a classe ou método poderá trabalhar com qualquer tipo.
*/

void genericExamples()
{
    // Aqui o <T> foi substituido pelo tipo int
    GenericExample<int> genericTest = new GenericExample<int>();
    // Aqui o <T> foi substituido pelo tipo string
    GenericExample<string> genericTest2 = new GenericExample<string>();

    // As duas formas funcionando, com tipos diferentes, mas com o mesmo código.
    genericTest.ShowValue(1540);
    genericTest2.ShowValue("teste generic c#");
}

// <T> é a forma usada para definir que essa classe usará Generic. Ele é substituído na criação de um objeto da classe.
public class GenericExample<T>
{
    public void ShowValue(T valueExample)
    {
        Console.WriteLine(valueExample);
    }
}
#endregion Generics
