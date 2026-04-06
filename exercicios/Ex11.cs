// 11. Crie um método:
// a. Maior(int a, int b)
// Que retorna o maior número.

using System;
public class Ex11
{
    static int Maior(int a, int b)
    {
        if (a > b) return a;
        else return b;
    }
    public static void Executar()
    {

        Console.Write($"Número 1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write($"Número 2: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("------------------------------");
        Console.WriteLine($"O maior número é {Maior(num1, num2)}");

    }
}

