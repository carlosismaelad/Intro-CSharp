using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Insira seu nome: ");
            string name = Console.ReadLine();
            /* Lê da entrada padrão até a quebra de linha (quando o usuário aperta a tecla ENTER)
            Os dados inseridos são retornado na forma de string. */
            Console.WriteLine($"Olá, {name}! Tudo bem com você?");


            Console.WriteLine("Insira sua data de nascimento (DD/MM/AAAA):");
            string birthday = Console.ReadLine();
            // string birthday = Console.ReadLine().Split("/"); Também daria certo
            
            string[] vet = birthday.Split("/");
            string day = vet[0];
            string month = vet[1];
            string year = vet[2];

            Console.WriteLine($"Você nasceu no dia {day}, no mês {month}, do ano de {year}.");

        }
    }
}