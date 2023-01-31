namespace bytebank.Models.Administrative.Utils
{
    public class CheckingAccountList
    {
        // Criação de um array que armazena o objeto ContaCorrente
        private bytebank.Models.Account.CheckingAccount[] _itens;

        // Variavel necessaria para verificar se ainda existe espaço não inicializado no array.
        private int _nextPosition = 0;

        public bytebank.Models.Account.CheckingAccount[] Itens { get { return _itens; } private set { _itens = value; } }

        // Construtor da classe que inicializa o array com o tamanho desejado.
        public CheckingAccountList(int initialSize = 0)
        {
            _itens = new bytebank.Models.Account.CheckingAccount[initialSize];
        }

        public void AddAccount(bytebank.Models.Account.CheckingAccount item)
        {
            Console.WriteLine("AddAccount: Adicionando C/C na lista de contas armazenadas.");
            AddCapacityIfNecessary(_nextPosition + 1);
            _itens[_nextPosition] = item;
            ++ _nextPosition;
        }

        private void AddCapacityIfNecessary(int desiredCapacity)
        {
            if (desiredCapacity >= Itens.Length)
            {
                Array.Resize(ref _itens, desiredCapacity);
            }
        }

        public bytebank.Models.Account.CheckingAccount GetAccountWithGreaterBalance()
        {   
            Console.WriteLine("GetAccountWithGreaterBalance: Retornando a C/C com o maior saldo.");
            bytebank.Models.Account.CheckingAccount accountWithGreaterBalance = _itens[0];
            double greaterBalance = 0;

            foreach (bytebank.Models.Account.CheckingAccount account in _itens)
            {
                if (account.Balance > greaterBalance)
                {
                    accountWithGreaterBalance = account;
                    greaterBalance = account.Balance;
                }
            }
            return accountWithGreaterBalance;
        }

        public void DeleteAccount(bytebank.Models.Account.CheckingAccount account)
        {
            Console.WriteLine("DeleteAccount: Removendo C/C passada por parâmetro.");
            bytebank.Models.Account.CheckingAccount[] newItens = new bytebank.Models.Account.CheckingAccount[0];
            int arraySize = 0;

            for (int index = 0; index < _itens.Length; ++ index)
            {
                if (_itens[index] != account)
                {
                    if (arraySize <= newItens.Length) Array.Resize(ref newItens, arraySize + 1);
                    newItens[arraySize] = _itens[index];
                    ++ arraySize;
                }
            }

            if (_itens.Length == newItens.Length)
            {
                Console.WriteLine("Conta não encontrada.");
            } else
            {
                Console.WriteLine("Conta removida com sucesso.");
                _itens = newItens;
                -- _nextPosition;
            }
        }

        public void ShowAccounts()
        {   
            Console.WriteLine("ShowAccounts: Exibindo lista de C/C armazenadas");
            for (int index = 0; index < _itens.Length; ++ index)
            {
                bytebank.Models.Account.CheckingAccount account = _itens[index];

                Console.WriteLine($"Índice = {index}. Nº da C/C: {account.AccountCode} - Nº da agência: {account.AgencyCode} - Nome do Cliente: {account.Owner.Name}");
            }
        }

        public bytebank.Models.Account.CheckingAccount GetAccountByIndex(int index)
        {
            if(index < 0 || index > _itens.Length)
            {
                return _itens[index];
            } else
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        public int Size {
            get
            {
                return _nextPosition;
            }
            
        }

        /*
            ----- Indexadores -----
            Permitem que intâncias de uma classe ou struct sejam indexados como matrizes. O valor indexado
            pode ser definido ou recuperado sem especificar explicitamente um membro de instância ou tipo.

            Visão geral:
                . Os indexadores permitem que objetos sejam indexados de maneira semelhante às matrizes;
                . Um acessador get retorna um valor. Um acessador set atribui um valor (semelhante as propriedades);
                . A palavra-chave value é usada para definir o valor que está sendo atribuído pelo acessador set (semelhante as propriedades);
                . Os indexadores não precisam ser indexados por um valor inteiro. Você deve definir o mecanismo de pesquisa específico no get;
                . PODEM SER SOBRECARREGADOS (dependendo do argumento passado por parametro);
                . Os indexadores podem ter mais de um parâmetro formal, por exemplo, ao acessar uma matriz bidimensional.
        */
        public bytebank.Models.Account.CheckingAccount this[int index]
        {
            get
            {
                Console.WriteLine("Acessando a C/C por classe indexável");
                return _itens[index];
            }
            private set
            {
                _itens[index] = value;
            }
        }
    }
}