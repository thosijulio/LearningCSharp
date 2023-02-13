
namespace bytebank.Modelos.ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            this.CPF = cpf;
            this.Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        /*
            A combinação protected internal é um modificador de acesso de membro. Um membro com esse modificador é acessível
            no assembly atual ou nos tipos que derivam da classe recipiente.
            Neste exemplo, é possível criar dentro de bytebank_ATENDIMENTO > Program.cs uma classe "Estagiário", que herda de funcionário
            e utilizar o método getBonificação, algo que não seria possível se tivesse marcado apenas como "internal".
            Doc.: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/accessibility-levels
        */
        protected internal abstract double getBonificacao();
    }
}
