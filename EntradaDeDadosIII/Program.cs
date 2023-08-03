
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seus dados em uma única linha (Nome Idade Sexo(M/F) Altura)");
            string[] datas = Console.ReadLine().Split(" ");

            string name = datas[0];
            int years = int.Parse(datas[1]);
            char sexo = char.Parse(datas[2]);
            double height = double.Parse(datas[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"{name} tem {years} anos de idade, mede {height.ToString("F2", CultureInfo.InvariantCulture)} de altura e é do sexo {sexo}");



        }
    }
}