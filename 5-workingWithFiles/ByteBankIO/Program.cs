partial class Program
{
    static void Main()
    {
        Program.WorkingWithStreamReader();
        Console.Read();
        Program.CheckWrite();
    }

    static ByteBankIO.CheckingAccount ConvertStringToCheckingAccount(string textLine)
    {
        string[] values = textLine.Split(",");

        int agencyCode = int.Parse(values[0]);
        string ownerCpf = values[1];
        double balance = double.Parse(values[2].Replace(".", ","));
        string ownerName = values[3];

        ByteBankIO.Client owner = new ByteBankIO.Client(ownerName, ownerCpf, "Dev");

        ByteBankIO.CheckingAccount checkingAccount = new ByteBankIO.CheckingAccount(agencyCode, "Bytebank", balance, owner);

        return checkingAccount;
    }
}