namespace bytebank.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, bytebank.Modelos.ADM.SistemaInterno.IAutenticavel
    {
        public string Senha { get; set; }
        internal bytebank.Modelos.ADM.Utilitario.AutenticacaoUtil Autenticador { get; set; }
        
        public FuncionarioAutenticavel(double salario, string cpf, string password)
            : base(salario, cpf)
        {
            this.Senha = password;
        }
        public bool Autenticar(string senha)
        {
            return Autenticador.ValidarSenha(Senha, senha);
        }
    }
}
