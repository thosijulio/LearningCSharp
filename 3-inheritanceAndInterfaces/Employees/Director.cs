namespace Employees
{
    /*
        a classe diretor possuia todos os campos e métodos que a classe funcionário possuia.
        No exemplo, diretor é um funcionário. Em casos assim, podemos utilizar o conceito de HERANÇA.

        No c#, para definir que uma classe herda outra, é necessário usar o operador de dois pontos seguido pela classe que será herdada.
    */
    public class Director : Employees.Employee
    {
        /*
                    BASE
            Palavra reservada que é usada para acessar membros da classe base de dentro de uma classe derivada.
            Use para:
                . Chamar um método na clase base que foi sobrescrito por outro método
                . Especificar qual construtor de classe base deve ser chamado ao criar instâncias da classe derivada.
            O acesso a classe base é permitido apenas em um construtor, em um método de instancia e em um acessador de propriedade
            de instancia.

            Na linha abaixo, foi usado a palavra base para chamar o método construtor da classe pai para passar os parametros necessários
        */
        public Director(string name, string cpf, double salary) : base(name, cpf, salary){
            Console.WriteLine("Verificando ordem de execução - Método construtor da classe Director.");
        }

        // O modificador "Override" é necessário para extender ou modificar um método asbtrato ou virtual que foi herdado da classe pai.
        // Source: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override
        public override double getBonus()
        {
            // Ainda sobre base, na linha abaixo estou chamando a função getBonus que foi susbtituida por essa atual
            return base.getBonus() + this.Salary;
        }
    }
}
