// 8. Crie um programa que:
// a. leia vários números até o usuário digitar 0
// b. mostre a soma dos números

using System;
public class Ex8
{
    public static void Executar()
    {
        double soma = 0;
        bool diferenteZero = true;

        while (diferenteZero)
        {
            Console.WriteLine($"Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0) diferenteZero = false;

            soma += num;
        }

        Console.WriteLine("------------------------------");
        Console.WriteLine($"Soma: {soma}");

      } 
 }

