// 3. Faça um programa que:
// a. leia dois números
// b. calcule e exiba:
// c. soma
// d. subtração
// e. multiplicação
// f. Divisão

using System;
public class Ex3
{
    public static void Executar()
    {
        Console.WriteLine($"Digite o primeiro número:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Digite o segundo número:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------------");

        if (num2 == 0)
        {
            Console.WriteLine("Não é possível dividir um número por zero!");
            return;
        }

        Console.WriteLine($"{num1} + {num2} = {(num1 + num2):F2}");
        Console.WriteLine($"{num1} - {num2} = {(num1 - num2):F2}");
        Console.WriteLine($"{num1} x {num2} = {(num1 * num2):F2}");
        Console.WriteLine($"{num1} / {num2} = {(num1 / num2):F2}");
    }
}

