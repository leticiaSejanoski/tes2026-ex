// 9. Crie um método:
// a. Soma(int a, int b)
// Que retorna a soma.

using System;
public class Ex9
{
    static int Soma(int a, int b)
    {
        return a + b;
    }
    public static void Executar()
    {

        Console.Write($"Número 1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write($"Número 2: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("------------------------------");
        Console.WriteLine($"{num1} + {num2} = {Soma(num1, num2)}");


    }
}

