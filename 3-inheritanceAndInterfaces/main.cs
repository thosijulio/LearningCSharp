
Employees.Employee pedro = new Employees.Employee("Pedro", "45678912310", 2400.50);
Employees.Director ana = new Employees.Director("Ana", "12345678910", 8000);

Utils.BonusManager bonusManager = new Utils.BonusManager();

Console.WriteLine(pedro.Salary);
Console.WriteLine(ana.Salary);

bonusManager.registerBonus(pedro);
bonusManager.registerBonus(ana);

Console.WriteLine("Total de bônus concedido: " + Utils.BonusManager.totalBonus);
