using System;

namespace ForExerII
{
    class Program
    {
        static void Main(string[] args){

            Console.Write("Quantos números deseja inserir? ");
            int n = int.Parse(Console.ReadLine());

            int withinRange = 0;
            int outOfRange = 0;

            for(int i = 0; i < n; i++){
                Console.Write($"Valor #{i}: ");
                int value = int.Parse(Console.ReadLine());

                if (value >= 10 && value <=20){
                    withinRange++;
                } 
                else{
                    outOfRange++;
                }
            }
            Console.WriteLine($"in: {withinRange}");
            Console.WriteLine($"out: {outOfRange}");
        }
    }
}