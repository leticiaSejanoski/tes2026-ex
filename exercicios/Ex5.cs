// 5. Leia um número e informe:
// a. positivo
// b. negativo
// c. Zero

using System;
public class Ex5
{
  public static void Executar()
  {
    Console.WriteLine("Digite um número: ");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine("------------------------------");

    if (num > 0) Console.WriteLine($"{num} é positivo!");
    else if (num < 0) Console.WriteLine($"{num} é negativo!");
    else Console.WriteLine($"{num} é zero!");

  }
}

