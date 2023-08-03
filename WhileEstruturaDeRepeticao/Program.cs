using System;
using System.Globalization;

namespace WhileEstruturaDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            double x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0){

                double root = Math.Sqrt(x);
                Console.WriteLine($"Raiz quadrada de {x} = {root.ToString("F3", CultureInfo.InvariantCulture)}");

                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine());

            }

            Console.WriteLine("Número negativo! Encerrando...");

            
        }
    }
}
