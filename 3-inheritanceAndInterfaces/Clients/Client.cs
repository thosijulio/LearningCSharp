namespace Clients
{
    // A classe Object já é herdade automaticamente, não é necessário explicitar a herança. Além disso
    // caso posteriomente a classe Client seja herdeira de outra classe, basta remover a Object e colocar a classe. As duas seriam herdadas.
    public class Client:Object
    {
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Client(string cpf, string email, string password)
        {
            this.Cpf = cpf;
            this.Email = email;
            this.Password = password;
        }

        // No c#, toda classe herda indiretamente a classe Object, então é possível sobrescrever seus métodos virtuais (ToString, Equals, GetHashCode, etc);
        public override string ToString()
        {
            return $"{this.Cpf}, {this.Email}, {this.Password}";
        }
    }
}