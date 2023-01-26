namespace Utils
{
    public class BonusManager
    {
        // Propriedade estática que salva o total de bonificações já concedidas para cada funcionario;
        // Ela é estática para seu valor permanecer igual sempre, independente de quantas instancias forem criadas.
        static public double TotalBonus { get; private set; }

        /*
                        SOBRECARGA DE MÉTODOS
            Recurso da POO que permite implementar mais de 
            um método com o mesmo nome em uma classe.
            OBS.: Para a criação de métodos com o mesmo nome,
            os parâmetros tem que ser necessariamente diferentes.

                            POLIMORFISMO
            Recurso da POO em que um método (registerBonus) pode ter
            comportamentos diferentes de acordo com o parâmetro recebido.
        */
        public void registerBonus(Employees.Manager manager)
        {
            TotalBonus += manager.getBonus();
        }

        public void registerBonus(Employees.Director director)
        {
            Console.WriteLine("Outro comportamento quando um diretor for passado por parâmetro");
            TotalBonus += director.getBonus();
        }

        public void registerBonus(Employees.Assistant assistant)
        {
            TotalBonus += assistant.getBonus();
        }

        public void registerBonus(Employees.Designer designer)
        {
            TotalBonus += designer.getBonus();
        }
    }
}