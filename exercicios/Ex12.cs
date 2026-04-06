// 2. Crie um método:
// a. Media(double a, double b, double c)

using System;
public class Ex12
{
    static double Media(double n1, double n2, double n3)
    {
        double media = (n1 + n2 + n3) / 3;
        return media;
    }
    public static void Executar()
    {

        Console.Write($"Nota 1: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write($"Nota 2: ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write($"Nota 3: ");
        double n3 = double.Parse(Console.ReadLine());

        Console.WriteLine("------------------------------");
        Console.WriteLine($"Média: {(Media(n1, n2, n3)):F1}");


    }
}

