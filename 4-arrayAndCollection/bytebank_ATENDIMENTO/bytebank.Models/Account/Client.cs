namespace bytebank.Models.Account
{
    public class Client
    {

        public string Cpf { get; set; }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome do titular precisa ter pelo menos 3 caracteres.");
                }
                else
                {
                    _name = value;
                }
             }

        }

        public string Occupation { get; set; }

        public static int RegisteredClientsAmount { get; set; }

        public Client(string cpf, string name, string occupation)
        {
            _name = name;
            Cpf = cpf;
            Occupation = occupation;
            ++ RegisteredClientsAmount;
        }
    }
}
