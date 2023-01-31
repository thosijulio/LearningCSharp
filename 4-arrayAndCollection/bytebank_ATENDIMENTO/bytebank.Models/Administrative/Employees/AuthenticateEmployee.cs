namespace bytebank.Models.Administrative.Employees
{
    public abstract class AuthenticateEmployee : Employee, bytebank.Models.Administrative.InternalSystem.IAuthenticate
    {
        public string Password { get; private set; }

        public AuthenticateEmployee(double salario, string cpf, string name, string password) : base(salario, cpf, name){
            Password = password;
        }

        public bool Authentication(string password)
        {
            return Password == password;
        }
    }
}
