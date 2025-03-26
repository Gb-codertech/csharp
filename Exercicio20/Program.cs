using System;
public class Exercicio20
{
    public static void Main(string[] args)
    {

        double valorDecimal = 199.51; // Recebe número decimal
        int valorInteiro = Convert.ToInt32(valorDecimal); // Transforma em um valor arredondado inteiro

        Console.WriteLine($"Número Decimal {valorDecimal} - Número Inteiro {valorInteiro}");


        long numeroLongo = 4518444080000000; // Recebe o número longo 
        int numero = (int)numeroLongo; // Transforma em um número menor mas perde informação || Se usar o convert pode ter um erro

        Console.WriteLine($"Número Longo {numeroLongo} - Número Pequeno {numero}");


        char letra = 'A'; // Recebe uma letra
        int letraNumero = (letra); // Transforma a letra em um int (número do código ASCII)

        Console.WriteLine($"Letra {letra} - Número do código ASCII {letraNumero}");


        int maiorByte = 282; // Recebe um número inteiro
        int mByte = (byte)maiorByte; // Transforma o número inteiro em um número da escala dos Bytes

        Console.WriteLine($"Número maior que um Byte {maiorByte} - Número do Byte {mByte}");


        double numeroMaior = 0101119349104919.589185901958190599118435819; // Recebe um número decimal grande (double) e
        float numeroMenor = (float)numeroMaior; // Transforma em um número decimal menor (float)

        Console.WriteLine($"Número maior (Double) {numeroMaior} - Número menor (Float) {numeroMenor}");
    }
}