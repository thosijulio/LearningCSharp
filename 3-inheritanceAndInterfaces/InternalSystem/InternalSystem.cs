namespace InternalSystem
{
    public class InternalSystem
    {
        public bool Login(Authentication employee, string password)
        {
            bool authenticated = employee.Authenticate(password);

            if (authenticated)
            {
                Console.WriteLine("Usuário logado");
                return true;
            } else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}