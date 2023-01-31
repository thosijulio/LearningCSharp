namespace bytebank.Models.Administrative.InternalSystem
{
    public interface IAuthenticate
    {
        bool Authentication(string senha);
    }
}
