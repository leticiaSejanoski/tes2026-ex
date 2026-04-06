// 4. Crie um programa que:
// a. leia a idade de uma pessoa
// b. informe se ela é maior ou menor de idade

using System;
public class Ex4
{
    public static void Executar()
    {
        Console.WriteLine("Digite a sua idade");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18) Console.WriteLine($"Você é maior de idade!");
        else Console.WriteLine($"Você é menor de idade!");
    }
}

