namespace Employees
{
    /*
        Employee tornou-se uma classe abstrata, sendo assim, não é possui criar uma instancia a partir dessa classe, apenas de suas herdeiras.

    */
    public abstract class Employee {
        // Agrupar linhas no vscode studio (#region / #endregion) 
        #region
        /* 
        Método construtor da classe. Não é necessário criar, pois toda classe já possui um construtor padrão.
            Sempre o construtor da classe pai será executado antes em relação ao método da classe herdeira.

            Ainda sobre construtores:
        Podemos aplicar os modificadores de acesso (visibilidade) aos construtores, como private ou protected, para a execução de uma tarefa específica
        ou para não permitir que a classe gere instâncias (objetos);

        O construtor também é um método, portanto, podemos aplicar sobrecargas sobre ele. Assim, é possível haver mais de um construtor definido em
        uma mesma classe e cada um deles vai se diferenciar de acordo com sua assinatura (conjunto tipo de retorno e listagem de parâmetros que recebe).
        */
        #endregion
        public Employee(string name, string cpf, double salary)
        {
            Console.WriteLine("Verificando ordem de execução - Método construtor da classe Employee.");
            this.Name = name;
            this.Cpf = cpf;
            this.Salary = salary;
            ++totalEmployees;
        }

        public string Name { get; private set; }
        public string Cpf { get; private set; }

        /* modificador private não permite setar propriedade em uma classe herdeira, ela é visível somenta na superclasse.
        O protected permite e ainda bloqueia de edições fora da classe*/
        public double Salary { get; protected set; }

        // Propriedade com a palavra reservada STATIC significa que ela pertence a classe, e não ao objeto.
        // Para definir um valor padrão para uma propriedade, basta utilizar o sinal de igualdade após fechar chaves.
        public static int totalEmployees { get; private set; } = 0;

        // o modificador "virtual" é usado para modificar um método, propriedade, index ou declaração
        // nas suas classes herdeiras. Por exemplo, o método getBonus tem esse comportamento padrão 
        public virtual double getBonus()
        {
            return Salary * 0.1;
        }

        // O modificador "abstract" é usado para obrigar as classes herdeiras que criem um método com esse nome e retorno
        // porem, não é possível definir um método padrão, exatamente por que obriga as herdeiras a criarem.
        public abstract void raiseSalary();
    }
}
