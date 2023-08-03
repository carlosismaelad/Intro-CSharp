using System;

namespace ForExerI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor inteiro para ver a lista dos ímpares começando de 0");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++){
                if (i % 2 != 0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}