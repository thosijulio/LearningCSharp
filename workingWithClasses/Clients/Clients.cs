namespace Clients
{
    class Client
    {

        // Imagine um cenário onde a classe cliente possua 15 campos privados. Para cada um desses, seria necessário criar os métodos set/get publicos.
        // Para reduzir a quantidade de código necessário e ainda deixar esses campos "seguros", o c# possui as propriedades.
        private string _name = "";
        //Exemplo de propriedade:
        //  O acessor set é chamado quando algum valor é atribuido a propriedade.
        //  O Acessor get é chamado quando ao tentar receber o valor da propriedade.
        public string Name {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _cpf = "";
        public string Cpf {
            get { return this._cpf; }
            set { this._cpf = value; }
        }
        
        private string _occupation = "";
        public string Occupation {
            get { return this._occupation; }
            set { this._occupation = value; }
        }
    }
}