using bytebank_ATENDIMENTO.bytebank.Atendimento;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
new ByteBankAtendimento().AtendimentoCliente();


Console.WriteLine(bytebank_GeradorChavePix.GeradorChavePix.GetChavesPix(10));

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