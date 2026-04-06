// 13. Crie uma classe Carro com os seguintes atributos:
// a. Marca
// b. Modelo
// c. Ano
// d. No Main:
// i. criar um objeto Carro
// ii. preencher os dados
// iii. exibir as informações na tela

// 14. Adicione à classe Carro o método:
// a. ExibirDados()
// b. Esse método deve mostrar:
// i. marca
// ii. modelo
// iii. Ano

using System;
using System.Collections.Generic;

public class Ex13_14
{
    public static void Executar()
    {

        Carro c1 = new Carro();
        c1.marca = "Toyota";
        c1.modelo = "Corolla";
        c1.ano = 2020;
        c1.ExibirDados();

    }
}

