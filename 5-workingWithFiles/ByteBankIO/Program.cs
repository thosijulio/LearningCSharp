class Program
{
    static void Main(string[] args)
    {
        // Para não precisar passar o caminho completo do arquivo, basta coloca-lo na pasta onde se encontram
        // os exe gerados pela aplicacao (bin/Debug/netX.0)
        string fileAddress = "contas.txt";

        /*
            FileStream
            Classe que provê um fluxo de uma sequência de bytes p/ um arquivo, suportando
            tanto operações assíncronas como síncronas de leitura e escrita.

            FileStream aceita como primeiro parametro e endereço do arquivo e outras informações, como por exemplo o que será feito com esse arquivo.
        */
        FileStream fs = new FileStream(fileAddress, FileMode.Open);

        byte[] buffer = new byte[1024]; // 1024 = 1KB;

        fs.Read(buffer, 0, 1024);
        Console.ReadLine();
    }
}