namespace Utils
{
    public class BonusManager
    {
        // Propriedade estática que salva o total de bonificações já concedidas para cada funcionario;
        static public double totalBonus { get; private set; }

        /*
                        SOBRECARGA DE MÉTODOS / POLIMORFISMO
            Recurso da POO em que um método (registerBonus) pode ter comportamentos
            diferentes de acordo com o parâmetro recebido.
        */
        public void registerBonus(Employees.Employee employee)
        {
            totalBonus += employee.getBonus();
        }

        public void registerBonus(Employees.Director director)
        {
            Console.WriteLine("Outro comportamento quando um diretor for passado por parâmetro");
            totalBonus += director.getBonus();
        }
    }
}