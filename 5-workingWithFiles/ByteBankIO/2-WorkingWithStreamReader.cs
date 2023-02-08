partial class Program
{
    static void WorkingWithStreamReader()
    {
        string fileAddress = "contas.txt";

        using(FileStream fs = new FileStream(fileAddress, FileMode.Open))
        {
            /*
                StreamReader
                    Parecido com o método Reader do FileStream, porém, mais simples de utilizar
                    Não precisa criar um array de buffer, nem tratar até onde ele foi preenchido.
                    A ideia é ler um arquivo sem ter muitas complicações ou deixar o código muito grande.
            */
            StreamReader reader = new StreamReader(fs);

            /*
                Read(): Lê e retorna o próximo caracter do stream e avança sua posição em um caracter. Sê o stream não possuir mais caracter, retorna -1.
            */
            int number = reader.Read();

            /*
                ReadLine(): Lê apenas uma linha do arquivo.
            */
            string? line = reader.ReadLine();

            while (line != null)
            {
                ByteBankIO.CheckingAccount checkingAccount =  ConvertStringToCheckingAccount(line);

                Console.WriteLine(checkingAccount.ToString());

                line = reader.ReadLine();
            }

            
            /* ReadToEnd(): Lê todo o conteúdo do arquivo de uma vez.
                Método não indicado para arquivos muito grandes, pois ocupa o espaço na memória de uma vez.
            */
            string text = reader.ReadToEnd();

            // retorna true se a posição atual do stream estiver no fim dele, ou false caso contrário. Útil para ler o arquivo inteiro sem precisar usar o ReadToEnd() (Ex.: while(!EndOfStream){ ReadLine(); })
            bool endOfStream = reader.EndOfStream;

            Console.WriteLine("ReadLine(): " + line);

            Console.WriteLine("Read(): " + number);

            Console.WriteLine("ReadToEnd(): " + text);
        }
    }
}