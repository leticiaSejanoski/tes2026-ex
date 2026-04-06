// 22. Crie um vetor de Carro com 3 posições.
// a. Para cada posição:
// i. ler marca, modelo e ano
// ii. armazenar no vetor

// 23. Exiba todos os carros do vetor.

// 24. Calcule:
// a. A média dos anos dos carros do array.

// 25. Desafio: Permita que o usuário:
// a. escolha um carro pelo índice
// b. adicione ou remova carros


using System;
using System.Collections.Generic;

public class Ex22_23_24_25
{
    enum Menu { Escolher = 1, Adicionar, Remover, Sair };

    public static void mostraMenu()
    {
        Console.WriteLine("=====SELECIONE UMA OPÇÃO======");
        Console.WriteLine("1-Escolher Carro\n2-Adicionar Carro\n3-Remover Carro\n4-Sair");
        Console.WriteLine("==================");
    }

    static void preencherVetorCarros(Carro[] carros)
    {
        for (int i = 0; i < carros.Length; i++)
        {
            carros[i] = new Carro();
            Console.WriteLine($"-> Carro[{i}]");
            Console.Write("Marca: ");
            carros[i].marca = Console.ReadLine();
            Console.Write("Modelo: ");
            carros[i].modelo = Console.ReadLine();
            Console.Write("Ano: ");
            carros[i].ano = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
        }
    }

    static void EscolherCarro(List<Carro> lista)
    {
        Listar(lista);
        Console.WriteLine("Escolha um carro pelo índice: ");
        int indice = int.Parse(Console.ReadLine());
        if (indice >= 0 && indice < lista.Count)
        {
            Console.WriteLine("-----Carro selecionado-----");
            lista[indice].ExibirDados();
        }
        else
        {
            Console.WriteLine("Índice inválido!\n");
        }
        Console.ReadLine();
    }

    static void AddCarro(List<Carro> lista)
    {
        Carro c = new Carro();
        Console.WriteLine("-----Adicionar carro-----");
        Console.Write("Marca: ");
        c.marca = Console.ReadLine();
        Console.Write("Modelo: ");
        c.modelo = Console.ReadLine();
        Console.Write("Ano: ");
        c.ano = int.Parse(Console.ReadLine());
        lista.Add(c);
        Console.WriteLine("Carro adicionado!\n");
        Console.ReadLine();
    }

    static void RemoverCarro(List<Carro> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("Lista vazia!\n");
            return;
        }

        Listar(lista);
        Console.WriteLine("Índice do carro que deseja remover: ");

        int indice = int.Parse(Console.ReadLine());
        if (indice >= 0 && indice < lista.Count)
        {
            lista.RemoveAt(indice);
            Console.WriteLine("Carro removido!\n");
        }
        else
        {
            Console.WriteLine("Índice inválido!\n");
        }
        Console.ReadLine();
    }

    static void Listar(List<Carro> lista)
    {
        int i = 0;
        foreach (Carro carro in lista)
        {
            Console.WriteLine($"====Carro[{i}]====");
            carro.ExibirDados();
            Console.WriteLine("---------------------");
            i++;
        }
    }

    public static void Executar()
    {
        Carro[] carros = new Carro[3];
        preencherVetorCarros(carros);

        for (int i = 0; i < carros.Length; i++)
        {
            Console.WriteLine($"\n========Carro[{i}]=============\n");
            carros[i].ExibirDados();
        }

        int soma = 0;
        for (int i = 0; i < carros.Length; i++)
        {
            soma += carros[i].ano;
        }

        Console.WriteLine("-----------------------");
        Console.WriteLine($"Média dos anos dos carros: {soma / carros.Length}");

        Console.WriteLine("-----------------------\n");

        List<Carro> lista = new List<Carro>(carros);

        bool executando = true;
        while (executando)
        {
            mostraMenu();
            int op = int.Parse(Console.ReadLine());

            switch ((Menu)op)
            {
                case Menu.Escolher:
                    EscolherCarro(lista);
                    break;
                case Menu.Adicionar:
                    AddCarro(lista);
                    break;
                case Menu.Remover:
                    RemoverCarro(lista);
                    break;
                case Menu.Sair:
                    executando = false;
                    break;
            }
            Console.Clear();
        }
    }
}

