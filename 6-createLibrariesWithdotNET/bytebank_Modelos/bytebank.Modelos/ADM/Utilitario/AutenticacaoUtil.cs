namespace bytebank.Modelos.ADM.Utilitario
{
    /*
        As classes FuncionarioAutenticavel e Parceiro comercial possuiam o mesmo método (ValidarSenha).
        O mesmo código escrito em lugares diferentes. Conforme a aplicação cresce, isso pode causar problema de manutenção.

        Para corrigir isso, o melhor seria separar esse método em uma classe separada. Não poderia ser na classe base de FuncionarioAutenticavel (Funcionario),
        pois a classe ParceiroComercial não pode herdar todos os métodos e propriedades.

        A solução foi criar um classe separada AutenticacaoUtil. Dessa forma, a classe que precisar de um método de autenticação, basta criar uma instancia dela
        e chamar o método ValidarSenha.

        O problema é que se deixarmos ela como public, seria possível instanciar em qualquer lugar da aplicação, e o ideal seria apenas dentro do assembly atual
        (https://learn.microsoft.com/pt-br/dotnet/standard/assembly/). Para previnir isso, utilizamos o nível de acessibilidade internal.
    */
    internal class AutenticacaoUtil
    {
        public bool ValidarSenha(string realPassword, string passwordTriedByUser)
        {
            return realPassword.Equals(passwordTriedByUser);
        }
    }
}