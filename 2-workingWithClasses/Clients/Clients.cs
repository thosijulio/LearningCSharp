namespace Clients
{
    class Client
    {

        // Imagine um cenário onde a classe cliente possua 15 campos privados. Para cada um desses, seria necessário criar os métodos set/get publicos.
        // Para reduzir a quantidade de código necessário e ainda deixar esses campos "seguros", o c# possui as propriedades.

        /*
            Modificadores de acesso:
                public: acessível de qualquer ponto do código, ou seja não impõe restrições;
                private: acessível somente dentro do contexto onde foi declarado, ou seja, um membro privado dentro de uma classe só é acessível dentro da própria classe;
                protected: o elemento é acessível dentro da classe e suas derivadas;
                internal: é o padrão no C#. Caso nenhum modificador seja declarado, definirá a acessibilidade do elemento dentro do executável ou dll onde foi declarado;
                protected internal: é proveniente união dos modificadores protected e internal.
        */
        private string _name = "";
        //Exemplo de propriedade:
        //  O acessor set é chamado quando algum valor é atribuido a propriedade.
        //  O Acessor get é chamado quando ao tentar receber o valor da propriedade.
        public string Name {
            get { return this._name; }
            private set { this._name = value; }
        }
        
        private string _cpf = "";
        public string Cpf {
            get { return this._cpf; }
            private set { this._cpf = value; }
        }
        
        // Exemplo de uma propriedade autoimplementada.
        //  Torna a declaração amis concisa quando nenhum lógica adicional é necessária nos acessadores de propriedade.
        // Para ler mais sobre, acesse: https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
        public string Occupation { get; private set; } = "";

        // Método construtor de uma classe em C#. É um método com o nome da própria classe, em que é possível passar como parâmetro valores que podem ser usados
        // para definir campos logo quando a classe é instanciada. Seus valores se tornam obrigatórios.
        public Client(string cpf, string name, string occupation) {
            Cpf = cpf;
            Name = name;
            Occupation = occupation;
        }
    }
}