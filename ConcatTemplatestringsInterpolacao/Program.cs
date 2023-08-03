using System.Globalization;
namespace IntroCsharp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Maria Green";
            char sexo = 'F';
            int idade = 32;
            double saldo = 10.35479;

            // Usando placeholders
            Console.WriteLine("{0} tem {1} anos. É do sexo {2} e seu saldo é de {3:F2}", name, idade, sexo, saldo);

            // Usando interpolação
            Console.WriteLine($"{name} tem {idade} anos. É do sexo {sexo} e seu saldo é de {saldo:F2}");

            // Usando concatenação
            Console.WriteLine(name + " tem " + idade + " anos. É do sexo " + sexo + " e seu saldo é de " + saldo.ToString("F2", CultureInfo.InvariantCulture));

            // Só é possível alterar o separador de decimais com o ToString. As demais formas não suportam esse método.
        }
    }
}