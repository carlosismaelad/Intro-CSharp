using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Informe seu nome:");
            string name = Console.ReadLine();

            Console.WriteLine("Informe sua idade:");
            int years = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sexo (M/F):");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura:");
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{name} tem {years} anos, mede {height.ToString("F2", CultureInfo.InvariantCulture)} de altura e é do sexo {sexo}");
        }
    }

}