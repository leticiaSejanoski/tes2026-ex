// 7. Leia 5 números e exiba:
// a. a soma total
// b. a média

using System;
public class Ex7
{
    public static void Executar()
    {
       double soma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite a nota {i + 1}: ");
            soma += double.Parse(Console.ReadLine());
        }

        Console.WriteLine("------------------------------");
        Console.WriteLine($"Soma total: {soma:F1}");
        Console.WriteLine($"Média: {(soma / 5):F1}");

      } 
 }

