namespace Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            double d = Convert.ToDouble(Console.ReadLine());
            decimal mmTotal = (decimal)(d * 25.4);
            int m = (int)(mmTotal / 1000);
            int c = (int)(mmTotal / 10);
            decimal mm = mmTotal - m * 1000 - c * 10;
            Console.WriteLine("{0} дюйм = {1} м {2} см {3} мм", d, m, c, mm);
                
            
        }
    }
}
