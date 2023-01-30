namespace bytebank.Utils
{
    public class CheckingAccountList
    {
        // Criação de um array que armazena o objeto ContaCorrente
        private bytebank.Models.Account.CheckingAccount[] _itens;

        // Variavel necessaria para verificar se ainda existe espaço não inicializado no array.
        private int _nextPosition = 0;

        public bytebank.Models.Account.CheckingAccount[] Itens { get { return _itens; } private set { _itens = value; } }

        // Construtor da classe que inicializa o array com o tamanho desejado.
        public CheckingAccountList(int initialSize = 1)
        {
            _itens = new bytebank.Models.Account.CheckingAccount[initialSize];
            ++ _nextPosition;
        }

        public void AddAccount(bytebank.Models.Account.CheckingAccount item)
        {
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

        public bytebank.Models.Account.CheckingAccount getAccountWithGreaterBalance()
        {   
            bytebank.Models.Account.CheckingAccount accountWithGreaterBalance = _itens[0];
            double greaterBalance = 0;

            foreach (bytebank.Models.Account.CheckingAccount account in _itens)
            {
                if(account is bytebank.Models.Account.CheckingAccount)
                {
                    if (account.Balance > greaterBalance)
                    {
                        accountWithGreaterBalance = account;
                        greaterBalance = account.Balance;
                    }
                }
            }
            return accountWithGreaterBalance;
        }
    }
}