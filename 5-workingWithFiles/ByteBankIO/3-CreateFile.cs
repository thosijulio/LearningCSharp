partial class Program
{
    static void CreateFileWithWriter()
    {
        using(FileStream fs = new FileStream("createdFile.csv", FileMode.Create))
        {
            string accountAsString = "456, 7895, 1000.23, Gustavo Santos";
            // Para escrever uma string em um arquivo, é necessário fazer o processo oposto em relação a leitura. Ou seja, transformar uma string em bytes, e então criar o arquivo
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            byte[] accountConvertedInBytes = encoding.GetBytes(accountAsString);

            // Write aceita tres argumentos. Um array de bytes para ser escrito, o indice inicial e até aonde será escrito. P/ preencher todo o arquivo, utilizar o proprio length do array.
            fs.Write(accountConvertedInBytes, 0, accountConvertedInBytes.Length);
        }
    }

    /*
        Utilizando StreamWriter, o código fica mais fácil de se escrever, sem a necessidade de trabalhar com buffere e enconding.
    */
    static void createdFileWithStreamWriter()
    {
        string filePath = "newFile.csv";

        using(FileStream fs = new FileStream(filePath, FileMode.Create))
        using(StreamWriter writer = new StreamWriter(fs))
        {
            writer.Write("Valor registrado no arquivo sem precisar trabalhar com buffer");
        }
    }

    static void CheckWrite()
    {
        string filePath = "newFile.csv";

        using(FileStream fs = new FileStream(filePath, FileMode.Create))
        using(StreamWriter writer = new StreamWriter(fs))
        {
            /*
                Caso tente abrir o arquivo criado durante os Console.ReadLine, o arquivo estará vazio.
                Isso acontece pois o método write guarda o valor dentro de um buffer e só envia para o filestream quando está sendo finalizado o processo.
            */
            writer.WriteLine("Linha 0");
            writer.WriteLine("Linha 1");
            writer.WriteLine("Linha 2");
            writer.WriteLine("Linha 3");
            Console.ReadLine();
            writer.WriteLine("Linha 4");
            writer.Flush(); // Despeja o buffer direto para o stream.
            Console.ReadLine();
            writer.WriteLine("Linha 5");
            writer.WriteLine("Linha 6");
            writer.WriteLine("Linha 7");
            writer.WriteLine("Linha 8");
            Console.ReadLine();
            writer.WriteLine("Linha 9");
            writer.WriteLine("Linha 10");
        }
    }
}