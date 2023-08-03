using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 || 4 != 5; // true

            bool c2 = !(2 > 3) && 4 != 5; // true

            bool c3 = 10 <  5; // false

            // A precedência dos operadores é: !, && e ||. No Caso abaixo a operação "&&" será avaliada antes:
            bool c4 = c1 || c2 && c3; // c2 && c3 => False / c1(True) || False => True. Resultado de c4 = True
            Console.WriteLine(c4);


            // Vamos usar quase a mesma expressão, só que dessa vez negando o valor de c1:
            bool c5 = !c1 || c2 && c3; // Negação de c1(True) => Faslse; c2 && c3 => False; False || False => False
            Console.WriteLine(c5); // => False  
        }
    }
}