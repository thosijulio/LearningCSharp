
Console.WriteLine("\nCriando objeto da classe Director");
Employees.Director pedro = new Employees.Director("Pedro", "45678912310", 5000);
Console.WriteLine("\nCriando objeto da classe Designer");
Employees.Designer ana = new Employees.Designer("Ana", "12345678910", 3000);
Console.WriteLine("\nCriando objeto da classe Manager");
Employees.Manager otavio = new Employees.Manager("Ana", "12345678910", 4000);
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