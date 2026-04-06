// 6. Leia um número e exiba a tabuada de 1 a 10

using System;
public class Ex6
{
    public static void Executar()
    {
        Console.WriteLine("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("------------------------------");

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }

      } 
 }

