using System;

public class Exercicio17
{
    public static void Main(string[] args)
    {
        // Arrays para armazenar nomes dos filmes e anos de lançamento
        string[] nomesFilmes = { "Harry Potter", "Zorro", "Simpsons" };
        int[] anosLancamento = { 1999, 2010, 2014 };

        // Percorrer arrays com FOR
        Console.WriteLine("Filmes e seus lançamentos:");
        for (int contador = 0; contador < nomesFilmes.Length; contador++)
        {
            Console.WriteLine($"{nomesFilmes[contador]} - {anosLancamento[contador]}");
        }
    }
}
