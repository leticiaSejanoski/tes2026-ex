// 15. Crie uma classe Funcionario com os atributos:
// a. Nome
// b. Salario
// c. Cargo
// d. No Main:
// i. criar um objeto
// ii. preencher os dados
// iii. exibir as informações

// 16. Na classe Funcionario, implemente os métodos:
// a. ExibirDados()
// b. CalcularSalarioAnual()
// c. O método CalcularSalarioAnual() deve retornar:
// salario * 12

// 17. Adicione à classe Funcionario os métodos:
// a. AumentarSalario(double percentual)
// b. DescontarSalario(double valor)
// c. Regras:
// i. AumentarSalario: aumenta o salário com base em um percentual
// ii. DescontarSalario: reduz o salário com base em um valor informado

using System;
public class Funcionario
{
    public string nome;
    public double salario;
    public string cargo;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {nome}\nSalário: R${salario:F2}\nCargo: {cargo}\n");
    }

    public double CalcularSalarioAnual()
    {
        return salario * 12;
    }

    public void AumentarSalario(double percentual)
    {
        if (percentual <= 0)
        {
            Console.WriteLine("Percentual inválido!");
            return;
        }

        double aumento = salario * (percentual / 100);
        salario += aumento;
    }

    public void DescontarSalario(double valor)
    {
        salario -= valor;
    }
}



public class Ex15_16_17
{
    public static void Executar()
    {
        Funcionario f1 = new Funcionario();
        f1.nome = "Márcia";
        f1.salario = 1890;
        f1.cargo = "Caixa";
        f1.ExibirDados();
        f1.AumentarSalario(50);
        f1.ExibirDados();
        f1.DescontarSalario(103.87);
        f1.ExibirDados();
        Console.WriteLine($"Salário anual: R${(f1.CalcularSalarioAnual()):F2}");

    }
}


