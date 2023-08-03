using System.Globalization;
namespace IntroCsharp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8; // pelo menos um dos numero precisa receber casa decimal para que obtenhamos uma saída do tipo double

            //Calcullando delta
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4 * a * c; // Math.Pow para potenciação. Recebe dois parâmetros: a base e a potencia.
            // Mesmo que:
            //double delta = (b * b) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine("Delta: " + delta);
            Console.WriteLine("X1: " + x1);
            Console.WriteLine("X2: " + x2);
        }
    }
}



