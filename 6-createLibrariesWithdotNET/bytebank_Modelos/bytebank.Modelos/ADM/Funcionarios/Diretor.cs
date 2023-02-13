
namespace bytebank.Modelos.ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf, string password) : base(5000, cpf, password)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override double getBonificacao()
        {
            return this.Salario * 0.5;
        }
    }
}
