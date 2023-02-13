using bytebank_ATENDIMENTO.bytebank.Atendimento;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
new ByteBankAtendimento().AtendimentoCliente();


public class Estagiario : bytebank.Modelos.ADM.Funcionarios.Funcionario
{
    public Estagiario(double salario, string cpf) : base(salario, cpf)
    {
    }

    public override void AumentarSalario()
    {
        throw new NotImplementedException();
    }

    protected override double getBonificacao()
    {
        throw new NotImplementedException();
    }
}