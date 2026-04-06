public class Carro
{
    public string marca;
    public string modelo;
    public int ano;

    public void ExibirDados()
    {
        Console.WriteLine($"Marca: {marca}\nModelo: {modelo}\nAno: {ano}");
    }
}