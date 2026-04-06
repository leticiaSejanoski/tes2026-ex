// 2. Crie um programa que:
// a. leia um número inteiro
// b. exiba o dobro desse número

using System;
public class Ex2
{
    public static void Executar()
    {

        Console.WriteLine("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"O dobro de {num} é {num * 2}");

    }
}

