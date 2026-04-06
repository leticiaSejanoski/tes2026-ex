// 18. Crie um vetor de inteiros com 5 posições:
// a. leia os valores
// b. exiba todos

using System;
public class Ex18
{
    public static void Executar()
    {

        int[] numeros = new int[5];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número [{i}]: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Vetor: ");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"{numeros[i]} ");
        }

        Console.Write("\n");

    }
}

