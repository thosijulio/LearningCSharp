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

    Console.WriteLine("Hello, World!");
    Console.WriteLine("a int number: " + aIntNumber + "\r\na short number: " + aShortNumer + "\r\na long number: " + aLongNumber);
    Console.WriteLine("a double number: " + aDoubleNumber + "\r\na float number: " + aFloatNumber);
    Console.ReadLine();
  }
}