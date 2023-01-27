namespace Partners
{
    public class CommercialPartner
    {
        public string Password { get; set; }

        public bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}