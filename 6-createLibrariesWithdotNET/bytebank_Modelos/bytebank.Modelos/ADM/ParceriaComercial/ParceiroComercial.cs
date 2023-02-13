namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : bytebank.Modelos.ADM.SistemaInterno.IAutenticavel
    {
        public string Senha { get; set; }
        internal bytebank.Modelos.ADM.Utilitario.AutenticacaoUtil Autenticador { get; set; }
      
        public ParceiroComercial(string password)
        {
            Senha = password;
        }
        public bool Autenticar(string passwordTriedByUser)
        {
            return this.Autenticador.ValidarSenha(this.Senha, passwordTriedByUser);
        }
    }
}
