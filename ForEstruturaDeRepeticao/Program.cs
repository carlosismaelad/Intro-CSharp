using System;

namespace ForEstruturaDeRepericao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos número você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= n; i++){
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());

                soma += valor;
            }
            Console.WriteLine($"Total da soma dos valores: {soma}");


        }
    }
}