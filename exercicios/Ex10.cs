// 10. Crie um método:
// a. EhPar(int n)
// Que retorna verdadeiro ou falso.

using System;
public class Ex10
{
    static bool EhPar(int num)
    {
        if (num % 2 == 0) return true;
        else return false;
    }
    public static void Executar()
    {

        Console.Write($"Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("------------------------------");
        Console.WriteLine($"É par: {EhPar(num)}");


    }
}

