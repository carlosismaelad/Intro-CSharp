using System;

namespace WhileExerIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Qual o combustível da sua preferência?");
            Console.WriteLine("1.Alcool  2.Gasolina  3.Diesel  4.Sair");
            int tipo = int.Parse(Console.ReadLine());

            while(tipo != 4){
                if (tipo == 1){
                    alcool++;
                }
                else if (tipo == 2){
                    gasolina++;
                }
                else if (tipo > 4){
                    Console.WriteLine("Valor inválido, tente novamente.");
                }
                else {
                    diesel++;
                }

                Console.WriteLine("Votar novamente?");
                Console.WriteLine("1.Alcool  2.Gasolina  3.Diesel  4.Sair");
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Total de votos na pesquisa:");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}