
Employees.Employee pedro = new Employees.Employee("Pedro", "45678912310", 2400.50);
Employees.Director ana = new Employees.Director("Ana", "12345678910", 5000.28);
Utils.BonusManager bonusManager = new Utils.BonusManager();

Console.WriteLine(pedro.getBonus());
Console.WriteLine(ana.getBonus());

bonusManager.registerBonus(pedro);
bonusManager.registerBonus(ana);

Console.WriteLine("Total de bônus concedido: " + Utils.BonusManager.totalBonus);
