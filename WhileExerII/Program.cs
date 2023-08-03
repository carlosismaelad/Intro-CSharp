using System;

namespace WhileExerII
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] vet = Console.ReadLine().Split(' ');

            int x  = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while(x != 0 && y != 0){
                if (x > 0 && y > 0){
                    Console.WriteLine("Primeiro quadrante");
                }
                else if(x < 0 && y > 0){
                    Console.WriteLine("Segundo quadrante");
                }
                else if(x < 0 && y < 0){
                    Console.WriteLine("Terceiro quadrante");
                }
                else {
                    Console.WriteLine("Quarto quadrante");
                }

                Console.WriteLine("Insira novas coordenadas: ");
                vet = Console.ReadLine().Split(" ");
                x  = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }

            Console.WriteLine("Uma das coordenadas foi 0. Encerrando...");
        }
    }
}