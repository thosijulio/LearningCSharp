using System;

class HelloWorld
 {
  static void Main(string[] args)
  {
    double aIntNumber = 6.1565489;
    // para setar um valor do tipo double em uma variável do tipo int, é necessário fazer a conversão explícita desse valor (casting). O contrário não se faz necessário.
    int aDoubleNumber = (int)aIntNumber;

    // int: até 32bits; long: até 64bits; short: até 16bits.
    long aLongNumber = 1009128321834309123;
    short aShortNumer = 12324;

    Console.WriteLine("Hello, World!");
    Console.WriteLine("a int number: " + aIntNumber);
    Console.ReadLine();
  }
}