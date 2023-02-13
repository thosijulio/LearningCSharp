
namespace bytebank.Modelos.ADM.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf, string password) : base(4000, cpf, password)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override double getBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}
