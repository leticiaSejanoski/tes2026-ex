// 19. Leia 5 números e:
// a. mostre o maior valor

using System;
public class Ex19
{
    public static void Executar()
    {
        int[] numeros = new int[5];
        int maior = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número [{i}]: ");
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] > maior) maior = numeros[i];
        }

        Console.WriteLine($"O maior número do vetor é {maior}");

    }
}

