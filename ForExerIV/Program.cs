using System;
using System.Globalization;

namespace ForExerIII
{
    class Program
    {
        static void Main(string[] args){

            Console.Write("Quantidade de casos de teste? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++){
                string[] line = Console.ReadLine().Split(" ");

                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);

                if (a < 0){
                    Console.WriteLine("Divisão impossível");
                }
                else {
                    double div = (double)a / b;
                    Console.WriteLine($"Resultado: {div.ToString("F1", CultureInfo.InvariantCulture)}" );
                }
            }


        }

    }
}