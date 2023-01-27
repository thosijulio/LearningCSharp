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
    public abstract class Authentication : Employees.Employee
    {
        public Authentication(string name, string cpf, double salary) : base(name, cpf, salary)
        {
        }

        public string Password { get; set; } = "";

        public abstract bool Authenticate(string password);
    }
}