namespace Employees
{
    public class Employee {

        /* 
        Método construtor da classe. Não é necessário criar, pois toda classe já possui um construtor padrão.
            Sempre o construtor da classe pai será executado antes em relação ao método da classe herdeira.
        */
        public Employee(string name, string cpf, double salary)
        {
            Console.WriteLine("Verificando ordem de execução - Método construtor da classe Employee.");
            this.Name = name;
            this.Cpf = cpf;
            this.Salary = salary;
        }

        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public double Salary { get; private set; }

        // o modificador "virtual" é usado para modificar um método, propriedade, index ou declaração
        // nas suas classes herdeiras. Por exemplo, o método getBonus tem esse comportamento padrão 
        public virtual double getBonus()
        {
            return Salary * 0.1;
        }
    }
}
