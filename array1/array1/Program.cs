using System;
public class Array1
{
    public static void Main(string[] args)
    {
        int[] idadeAlunos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };

        // Percorrer array com FOR
        Console.WriteLine("Idade percorrida com for: ");

        for (int contador = 0; contador < idadeAlunos.Length; contador++)
        {
            Console.WriteLine(idadeAlunos[contador]);
        }

        // Percorrer array com FOREACH
        Console.WriteLine("Idade percorrida com Foreach: ");

        foreach (int idade in idadeAlunos) 
        { Console.WriteLine(idade); }
    }
}