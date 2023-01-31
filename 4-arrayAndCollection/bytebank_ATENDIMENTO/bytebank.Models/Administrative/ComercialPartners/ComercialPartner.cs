namespace bytebank.Models.Administrative.ComercialPartners

{
    public class ComercialPartner : bytebank.Models.Administrative.InternalSystem.IAuthenticate
    {
        public string Cpf { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }

        public ComercialPartner(string cpf, string name, string password)
        {
            this.Cpf = cpf;
            this.Name = name;
            this.Password = password;
        }

        public bool Authentication(string password)
        {
            return Password == password;
        }
    }
}
