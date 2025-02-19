using System;

namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double g = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());
            double s = Convert.ToDouble(Console.ReadLine());
            double rad = g*(Math.PI/180)+ m * (Math.PI / (180*60))+ s * (Math.PI / (180*60*60));
            

            Console.WriteLine(rad);
            Console.ReadKey();
        }
    }
}
