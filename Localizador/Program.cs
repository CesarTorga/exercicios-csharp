using System;

public class Program
{
    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
                return i;
        }
        return -1;
    }
    public static void Main()
    {
        int[] numeros = new int [] {0,2,4,6,8};
        Console.WriteLine("Digite o número que gostaria de encontrar");
        var numero = int.Parse(Console.ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numero);

        if(idxEncontrado >= 0)
        {
            Console.WriteLine($"O número digitado está na posição {idxEncontrado}");
        }
        else
        {
            Console.WriteLine("O número digitado não foi encontrado");
        }
    }
}