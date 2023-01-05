using System;

class HelloWorld
{
  static void workingWithPrimitiveVariables()
  {
    double aDoubleNumber = 6.1565489;

    // para setar um valor do tipo double em uma variável do tipo float, é necessário passar o sufíxo "f" para criar um literal desse tipo.
    float aFloatNumber = (float)aDoubleNumber;

    // para setar um valor do tipo double/float em uma variável do tipo int, é necessário fazer a conversão explícita desse valor (casting). O contrário não se faz necessário.
    int aIntNumber = (int)aDoubleNumber;

    /*
        Quando tentamos colocar um valor inteiro em uma variável do tipo double, o C# não mostra erro. Porém, quando tentamos colocar um double numa variável no tipo inteiro,
      temos um erro de compilação.
        Esta propriedade se dá por que o C# faz conversão implícita de um tipo menor para os tipos "maiores". De inteiro para double, por exemplo.
      O contrário não é verdade, pois existe perda de dados quando é feita a conversão. Isso acarreta um "type mismatch", mostrando que essa instrução é de tipos incompatíveis.
        Para fazer uma conversão em que pode haver perda de informações, é necessário fazer um type casting (conversão explícita).
    */

    // int: até 32bits; long: até 64bits; short: até 16bits.
    long aLongNumber = 1009128321834309123;
    short aShortNumer = 12324;

    Console.WriteLine("Hello, World! Working with some primitive variables:");
    Console.WriteLine("int number: " + aIntNumber + "\r\nshort number: " + aShortNumer + "\r\nlong number: " + aLongNumber);
    Console.WriteLine("double number: " + aDoubleNumber + "\r\nfloat number: " + aFloatNumber);

    // para declarar um caracter, é necessário o uso da aspa simples. P/ string, aspas duplas. O char usa a tabela ASCII para realizar a conversao de valores int e operações numéricas.
    // Uma string pode ser vazia. Um char precisa necessariamente possui um valor da tabela ASCII.
    char aChar = (char)65;

    Console.WriteLine("char: " + aChar);

    ++aChar;
    Console.WriteLine("incremented char: " + aChar);
  }
  static void workingWithFluxControl(int number)
  {
    Console.WriteLine("Now, working with flux control: ");

    // A escrita do if é igual a do c++.
    if (number > 5)
    {
      Console.WriteLine("IF ELSE - Number is greater than five.");
    }
    else
    {
      Console.WriteLine("IF ELSE - Number is lower than five.");
    }

    switch (true)
    {
        case true when number > 5:
            Console.WriteLine("Switch - Number is greater than five.");
            break;
        case true when number == 5:
            Console.WriteLine("Switch - Number is five.");
            break;
        default:
            Console.WriteLine("Switch - Number is lower than five.");
            break;
    }
  }
  static void Main(string[] args)
  {
    workingWithPrimitiveVariables();
    workingWithFluxControl(5);
    Console.ReadLine();
  }
}