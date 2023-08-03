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
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.00 + b * 3 + c * 5.00) / 10.0;

                Console.WriteLine($"Média ponderada dos números: {media.ToString("F1", CultureInfo.InvariantCulture)}");  
            }


        }

    }
}