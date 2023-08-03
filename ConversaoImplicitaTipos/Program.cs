using System.Globalization;
namespace IntroCsharp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Caso de conversão implícita de tipo:
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y); // saída 4.5
            // y é double mas ela recebeu um conteúdo float porque 4bytes cabem perfeitamente dentro de 8bytes

            // O inverso não daria certo
            double a = 4.5f;
            float b = (float)a;
            Console.WriteLine(b);
            /* Cannot implicitly convert type 'double' to 'float'. An explicit conversion exists (are you missing a cast?) 
            Porque double (8bytes) não cabe em um float (4bytes)
            Para fazermos o casting temos que colocar o tipo float entre parênteses antes da variável "a" repassada para "b"
            */


            // Podemos fazer o typecasting entre inteiros e double também
            double j = 5.1;
            int k = (int)j;
            Console.WriteLine(k); // retorna 5 porque precisa truncar as casas decimais. Houve perda de informação



            // string numero = "cinco";
            // int numInt = (int)numero;
            // Essa operação não poderá ser realizada porque
            // o C# não faz casting de string para numeros

            int m = 5;
            int n = 2;
            double o = m / n;
            Console.WriteLine(o); // retorna 2
            /* O compilador entendeu que querpiamos faer uma expressão de m/n 
            usando somente considerando valores inteiros.
            Então ele fez uma divisão inteira, descartou o ".5" */

            // Para corrigir a saída da expressão:
            o = (double) m / n;
            Console.WriteLine(o); // saida 2.5


        }
    }
}



