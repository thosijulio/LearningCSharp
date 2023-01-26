
Console.WriteLine("\nCriando objeto da classe Employee");
Employees.Employee pedro = new Employees.Employee("Pedro", "45678912310", 2000);
Console.WriteLine("\nCriando objeto da classe Director");
Employees.Director ana = new Employees.Director("Ana", "12345678910", 5000);

Utils.BonusManager bonusManager = new Utils.BonusManager();

Console.WriteLine("\nSalário do Employee Pedro: R$" + pedro.Salary);
Console.WriteLine("Salário da Director Ana: R$" + ana.Salary);


bonusManager.registerBonus(pedro);
bonusManager.registerBonus(ana);

Console.WriteLine("\nTotal de bônus concedido: " + Utils.BonusManager.TotalBonus);
Console.WriteLine("Total de Funcionários registrados: " + Employees.Employee.totalEmployees);