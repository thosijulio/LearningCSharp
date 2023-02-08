partial class Program
{
    static void WorkingWithFileStream()
    {
        // Para não precisar passar o caminho completo do arquivo, basta coloca-lo na pasta raiz da aplicação.
        string fileAddress = "contas.txt";

        /*
            FileStream
            Classe que provê um fluxo de uma sequência de bytes p/ um arquivo, suportando
            tanto operações assíncronas como síncronas de leitura e escrita.

            O fluxo de dados serve para o computador ler o arquivo aos poucos. Essa ideia existe p/ arquivos em geral. Ex.: Em um filme, o arquivo é carregado para a memória RAM
            aos poucos, se caso contrário, ocuparia todo o espaço de memória e inviabilizaria outros processos rodando em segundo plano. Então, o arquivo é "dividido" em partes.

            FileStream aceita como primeiro parametro e endereço do arquivo e outras informações, como por exemplo o que será feito com esse arquivo.

            APÓS o uso é NECESSÁRIO fechar (FileStream().Close) a conexão com o arquivo. Caso contrário, ele ficará travado para edição por outros programas enquanto a aplicação não for finalizadaa.
        */

        /*  IDisposable = Interface que fornece um mecanismo para liberar recursos não gerenciados.
            O uso principal disso é liberar recursos não gerenciados. O garbage collector libera automaticamente a memória alocada para um objeto gerenciado quando esse objeto não é mais usado.
            Using = instrução que fornece uma sintaxe conveniente que garante o uso correto de objetos IDisposable. Nesse caso, utilizando o using, não é necessário chamar o método FileStream.close(),
            pois o prório using se encarregará de liberar esse recurso.
        */
        using(FileStream fs = new FileStream(fileAddress, FileMode.Open))
        {
            /*
            o byte consegue armazenar um valor entre 0 e 255.
            */

            byte[] buffer = new byte[1024]; // 1024 = 1KB;

            /*
                Read
                Lê um bloco de bytes de um stream e escreve seus valores em um buffer passado por parâmetro.

                Retorna o numero total de bytes em um buffer (numberOfBytesRead). Isso poderá ser menor que o número de bytes solicitado se esse número de bytes não estiver disponível no momento,
                ou zero, se o final do fluxo for atingido.

                Então, para ler um arquivo inteiro, basta criar uma variável para ir guardando o numero de bytes, e ir atualizando essa variavel dentro de um loop. Enquanto a variavel não for 0,
                continua lendo o arquivo.
            */

            // -1 é um valor que não irá interferir na sequência de bytes porque os bytes ou são maiores que zero, ou zero. -1 nunca será retornado pelo read.
            // essa variável será atualizada a cada vez que o Read for lido

            int numberOfBytesRead = fs.Read(buffer, 0, 1024); // Irá popular a List buffer antes do primeiro loop.

            while(numberOfBytesRead != 0)
            {
                numberOfBytesRead = fs.Read(buffer, 0, 1024);
                Console.WriteLine("\n Bytes lidos = " + numberOfBytesRead);
                writeBuffer(buffer, numberOfBytesRead, fs);
            }

            static void writeBuffer(byte[] buffer, int numberOfBytesRead, FileStream fs)
            {
                System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding();
                
                /* UTF8.GetString() = faz a decodificação de uma sequencia de bytes passada por parametro em uma string.
                    Aceita como parametros:
                        o array de buffer que será traduzido como primeiro parametro (obrigatorio);
                        O índice de primerio byte que será decodificado;
                        A contagem de quantos bytes será decodificado desde o inicio.
                    
                    Se passarmos apenas o buffer, a GetString irá ler todo o conteúdo do buffer. Isso pode gerar o seguinte problema:
                        Imagine um arquivo de texto que possua 2000 bytes. Na primeira iteração nesse arquivo, o buffer será populado com 1024 bytes.
                        Na segunda, sobrou 976 bytes para serem lidos no arquivo, então o método FileStream.Read irá substituir os valores nas posições entre 0-975
                        e os valores restantes ainda serão os armazenados na iteração anterior. Para não ler esses arquivos, salvamos os valores que foram lidos em cada
                        iteração em uma variável (numberOfBytesRead, nesse caso), e passamos para o método GetString(). Dessa forma, apenas o conteúdo desejado será retornado.
                */
                string text = utf8.GetString(buffer, 0, numberOfBytesRead);

                Console.Write(text);

                /* IMPRIMINDO TODOS OS BYTES NO CONSOLE
                foreach(byte aByte in buffer)
                {
                    Console.Write(utf8.GetString(buffer) + " ");
                }
                */
            }

            // fs.Close(); Linha comentada pois não é necessário chamar o método close quando se está usando o "using".
        }

        Console.ReadLine();

    }
}