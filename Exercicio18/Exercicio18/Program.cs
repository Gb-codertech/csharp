using System;

public class Exercicio18
{
    public static void Main(string[] args)
    {
        // Arrays para armazenar Nomes das cidades e a população
        string[] nomesCidades = { "São Paulo", "Rio De Janeira", "Belo Horizonte", "Natal", "Lisboa", "Maringá", "Porto", "Governador Celso Ramos", "Coimbra"};
        int[] populacao = { 11500000, 6220000, 2320000, 751000, 545000, 410000, 237000, 146000, 143000 };

        // Percorrer arrays com FOR
        Console.WriteLine("Cidades e a suas populações:");
        for (int contador = 0; contador < nomesCidades.Length; contador++)
        {
            Console.WriteLine($"{nomesCidades[contador]} - {populacao[contador]} Habitantes");
        }
    }
}