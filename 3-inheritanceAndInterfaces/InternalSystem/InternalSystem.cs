namespace InternalSystem
{
    public class InternalSystem
    {
        public bool Login(IAuthentication user, string password)
        {
            bool authenticated = user.Authenticate(password);

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