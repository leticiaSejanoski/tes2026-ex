// 20. Leia 5 números e:
// a. calcule a média

using System;
public class Ex20
{
    public static void Executar()
    {

        int[] numeros = new int[5];
        int soma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número [{i}]: ");
            numeros[i] = int.Parse(Console.ReadLine());
            soma += numeros[i];
        }
        Console.WriteLine($"A média é: {(soma / numeros.Length):F2}");

    }
}

