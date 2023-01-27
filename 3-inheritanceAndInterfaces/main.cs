void testingClass()
{
    Console.WriteLine("\nCriando objeto da classe Director");
    Employees.Director pedro = new Employees.Director("Pedro", "45678912310", 5000, "123456");
    Console.WriteLine("\nCriando objeto da classe Designer");
    Employees.Designer ana = new Employees.Designer("Ana", "12345678910", 3000);
    Console.WriteLine("\nCriando objeto da classe Manager");
    Employees.Manager otavio = new Employees.Manager("Ana", "12345678910", 4000, "1234");
    Console.WriteLine("\nCriando objeto da classe Assistant");
    Employees.Assistant laura = new Employees.Assistant("Ana", "12345678910", 2000);

    Utils.BonusManager bonusManager = new Utils.BonusManager();

    Console.WriteLine("\nSalário do Employee Pedro: R$" + pedro.Salary);
    Console.WriteLine("Salário da Designer Ana: R$" + ana.Salary);
    Console.WriteLine("Salário do Gerende Otavio Ana: R$" + ana.Salary);
    Console.WriteLine("Salário da Assistente Laura: R$" + ana.Salary);


    bonusManager.registerBonus(pedro);
    bonusManager.registerBonus(ana);
    bonusManager.registerBonus(otavio);
    bonusManager.registerBonus(laura);

    Console.WriteLine("\nTotal de bônus concedido: " + Utils.BonusManager.TotalBonus);
    Console.WriteLine("Total de Funcionários registrados: " + Employees.Employee.totalEmployees);
}

/* 
    Da forma que o código foi escrito no último commit (5819d4b5795aeaf0a094e7824cbb968307942475), qualquer tipo de usuário consegue
    realizar a autenticação, foi o método de Login da class InternalSytem chama o método authenticate, que está na classe employee.
    Para corrigir isso, a solução encontrada de acordo com o conteúdo utilizado até o momento, foi criar uma classe intermediária entre
    Employees.Employee > InternalSystem.Authentication > Employees.Director/Employees.Manager. Dessa forma, apenas os usuário com essas classes
    tem acesso ao método de autenticação.
    O problema disso é que a classe Authentication precisa criar os métodos obrigatórios definidos em employees, além de ter que passar os atributos necessários
    no método construtor. Além de não fazer muito sentido semântido a class Director ser herdeira de Authentication.
 */
void UseSystem()
{
    InternalSystem.InternalSystem system = new InternalSystem.InternalSystem();

    Employees.Assistant roberto = new Employees.Assistant("Roberto", "123455", 2000);

    Employees.Director ingrid = new Employees.Director("Ingrid", "12345679", 5000, "123456");
    ingrid.Password = "123456";

    Employees.Manager julio = new Employees.Manager("Julio", "98765432", 3000, "1234");

    // Dessa forma atual (c/ interface), um parceiro comercial consegue se autenticar e não herda a classe Employee.
    Partners.CommercialPartner paloma = new Partners.CommercialPartner("123456");

    system.Login(ingrid, "123456");
    system.Login(julio, "12");
    system.Login(paloma, "12");
    // system.Login(roberto, "12334"); => Esse código gera um erro "cannot convert from 'Employees.Assistant' to 'InternalSystem.Authentication'", pois
    //  Assistant não herde a classe Authentication, logo, não consegue realizar o login.

    Clients.Client flavio = new Clients.Client("1", "2", "43");
    // Por padrão, o método ToString da classe Object retorna uma string contendo o caminho até a classe (namespace.classe)
    Console.WriteLine(flavio.ToString());
}

UseSystem();