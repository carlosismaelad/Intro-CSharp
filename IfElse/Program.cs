using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o horário: ");
            int horario = int.Parse(Console.ReadLine());

            if(horario < 12){
                Console.WriteLine("Bom dia!");
            } 
            else if(horario < 18){
                Console.WriteLine("Boa tarde");
            }
            else if(horario >=18){
                Console.WriteLine("Boa noite");
            }

            Console.WriteLine("Informe um numero inteiro");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0){
                Console.WriteLine($"O nuḿero {number} é par");
            } else {
                Console.WriteLine($"O número {number} é ímpar");
            }


        }
    }
}