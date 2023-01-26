namespace Employees
{
    public class Employee {

        /* 
        Método construtor da classe. Não é necessário criar, pois toda classe já possui um construtor padrão.
            Sempre o construtor da classe pai será executado antes em relação ao método da classe herdeira.

            Ainda sobre construtores:
        Podemos aplicar os modificadores de acesso (visibilidade) aos construtores, como private ou protected, para a execução de uma tarefa específica
        ou para não permitir que a classe gere instâncias (objetos);
        
        O construtor também é um método, portanto, podemos aplicar sobrecargas sobre ele. Assim, é possível haver mais de um construtor definido em
        uma mesma classe e cada um deles vai se diferenciar de acordo com sua assinatura (conjunto tipo de retorno e listagem de parâmetros que recebe).
        */
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
        public double Salary { get; private set; }

        // Propriedade com a palavra reservada STATIC significa que ela pertence a classe, e não ao objeto.
        // Para definir um valor padrão para uma propriedade, basta utilizar o sinal de igualdade após fechar chaves.
        public static int totalEmployees { get; private set; } = 0;

        // o modificador "virtual" é usado para modificar um método, propriedade, index ou declaração
        // nas suas classes herdeiras. Por exemplo, o método getBonus tem esse comportamento padrão 
        public virtual double getBonus()
        {
            return Salary * 0.1;
        }
    }
}
