using System;

namespace WhileExerI
{
    class Program{
        static void Main(string[] args)
        {
            string correctPassword = "csharp";

            Console.WriteLine("Informe sua senha: ");
            string password = Console.ReadLine();            

            while(password != correctPassword){
                Console.WriteLine("Senha incorreta, tente novamente: ");
                password = Console.ReadLine();
            }

            Console.WriteLine("Senha correta. Realizando login...");
        }
    }
}