using System;

class HelloWorld
 {
  static void Main(string[] args)
  {
    double aDoubleNumber = 6.1565489;

    // para setar um valor do tipo double em uma variável do tipo float, é necessário passar o sufíxo "f" para criar um literal desse tipo.
    float aFloatNumber = (float)aDoubleNumber;

    // para setar um valor do tipo double/float em uma variável do tipo int, é necessário fazer a conversão explícita desse valor (casting). O contrário não se faz necessário.
    int aIntNumber = (int)aDoubleNumber;

    // int: até 32bits; long: até 64bits; short: até 16bits.
    long aLongNumber = 1009128321834309123;
    short aShortNumer = 12324;

    Console.WriteLine("Hello, World! Working with numbers:");
    Console.WriteLine("int number: " + aIntNumber + "\r\nshort number: " + aShortNumer + "\r\nlong number: " + aLongNumber);
    Console.WriteLine("double number: " + aDoubleNumber + "\r\nfloat number: " + aFloatNumber);

    // para declarar um caracter, é necessário o uso da aspa simples. P/ string, aspas duplas. O char usa a tabela ASCII para realizar a conversao de valores int e operações numéricas.
    // Uma string pode ser vazia. Um char precisa necessariamente possui um valor da tabela ASCII.
    char aChar = (char)65;
    // usar @ antes das aspas duplas caso queira utilizar o enter como quebra de linha.
    string aString = @"a simples phrase
with two lines.";

    Console.WriteLine("char: " + aChar + "\r\nstring: " + aString);

    ++aChar;
    Console.WriteLine("incremented char: " + aChar);


    Console.ReadLine();
  }
}