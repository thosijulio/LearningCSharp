namespace bytebank.Models.Administrative.InternalSystem
{
    public class InternalSystem
    {
        public bool Login (bytebank.Models.Administrative.InternalSystem.IAuthenticate employee, string password)
        {
            bool userAuthenticate = employee.Authentication(password);

            if (userAuthenticate)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
