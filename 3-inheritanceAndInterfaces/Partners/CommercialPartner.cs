namespace Partners
{
    public class CommercialPartner: InternalSystem.IAuthentication
    {
        public string Password { get; set; }

        public CommercialPartner(string password)
        {
            this.Password = password;
        }
    }
}