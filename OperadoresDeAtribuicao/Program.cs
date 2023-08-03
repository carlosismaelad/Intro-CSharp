using System.Globalization;
namespace IntroCsharp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a++; // a saída será 10 porque "b" recebe 10 porque ele recebe a variável "a" e só depois a é incrementado, apesar de "b" ficar valendo 11 depois da saída
            Console.WriteLine(b); // retorna 10
            
            b = ++a;
            Console.WriteLine(b); // a saída serás 12

            int c = 10;
            int d = ++c; // b recebe 11 porque primeiro vem o incremento e depois "a";            
            Console.WriteLine(d); // retorna 11

        }
    }
}


