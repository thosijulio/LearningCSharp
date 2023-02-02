namespace ByteBankIO
{
    public class Client
    {
        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public string Occupation { get; private set; }

        public Client(string name, string cpf, string occupation)
        {
            Name = name;
            Cpf = cpf;
            Occupation = occupation;
        }
    }
}
