namespace InternalSystem
{
    /* 
        A classe autenticação é abstrato, pois não faz sentido criar uma instancia para ela.
        O método também, pois a classe Diretor e Manager precisam definir como será o método de autenticacao para si proprio.
        Além disso, ao definir a classe como abstrata, não temos que criar os métodos marcados como abstract da classe pai, precisando
        apenas criar o construtor para passar os campos necessários.

        O problema que fica é caso um usuário externo, que não seja employee, precisa usar o sistema e o método de autenticação.
        Ele necessáriamente será herdeiro de Employee, mesmo não sendo um Employee, devido a forma que o código foi escrito.
    */

    /*
        A solução para o problema acima é a criação de Interface.
        Uma interface serve para definir um contrato. Qualquer classe que implemente
        esse contrato obrigatoriamente precisa definir uma implementação dos membros definidos na interface.
        A partir do c#11, uma interface pode definir membros virtuais para declarar um tipo de implementação deve fornecer os membros declarados.
        Por convenção, utiliza-se o "I" no ínicio da interface para ficar fácil a vizualização dentro do código.
    */
    public interface IAuthentication
    {
        public string Password { get; set; }

        public virtual bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}