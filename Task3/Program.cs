namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task3_1();
            Task3_2();
            Task3_3();
            Task3_4();
            Task3_5();
            Task3_6();
            Task3_7();
            Task3_8();
            Task3_9();
            Task3_10();*/
            Task3_11();
        }
        static void Task3_1() {
            Console.WriteLine("Задание 1");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b) { Console.WriteLine(">"); }
            if (a == b) { Console.WriteLine("="); }
            if (a < b) { Console.WriteLine("<"); }

        }
        static void Task3_2()
        {
            Console.WriteLine("Задание 2");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int max = a;


            if (b > a) { max=b; }
            if (c > max) { max = c; }
            Console.WriteLine(max);

        }
        static void Task3_3()
        {
            Console.WriteLine("Задание 3");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int max = a;


            if (b > a) { max = b; }
            if (c > max) { max = c; }
            if (d > max) { max = d; }
            Console.WriteLine(max);

        }
        static void Task3_4()
        {
            Console.WriteLine("Задание 4");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int mid;


            if (a < b)
            {
                if (b < c)
                {
                    mid = b;
                }
                else if (a > c)
                {
                    mid = a;
                }
                else mid = c;
            }
            else if (a > b)
            {
                if (a < c)
                {
                    mid = a;
                }
                else if (b > c)
                {
                    mid = b;
                }
                else mid = c;
            }
            else mid = a;
            Console.WriteLine(mid);
            }
        static void Task3_5()
        {
            Console.WriteLine("Задание 5");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 10 == 0 || a == 0)
            {
                Console.WriteLine("Da");
            }
            else
            {
                Console.WriteLine("Net");
            }
        }
        static void Task3_6()
        {
            Console.WriteLine("Задание 6");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 || a == 0)
            {
                Console.WriteLine("Da");
            }
            else
            {
                Console.WriteLine("Net");
            }
        }
        static void Task3_7()
        {
            Console.WriteLine("Задание 7");
            int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            if (a >9 && a <100)
            {
                Console.WriteLine("Da");
            }
            else
            {
                Console.WriteLine("Net");
            }
        }
        static void Task3_8()
        {
            Console.WriteLine("Задание 8");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > -11 && a < 11)
            {
                Console.WriteLine("Da");
            }
            else
            {
                Console.WriteLine("Net");
            }
        }
        static void Task3_9()
        {
            Console.WriteLine("Задание 9");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 9 || a < -9)
            {
                Console.WriteLine("Da");
            }
            else
            {
                Console.WriteLine("Net");
            }
        }
        static void Task3_10()
        {
            Console.WriteLine("Задание 10");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a%10==1 ||a==1)
            {
                if(a<10 || a >20) 
                Console.WriteLine("Мы построили "+ a + " дом");
            }

            if (a > 9 && a < 21) { Console.WriteLine("Мы построили " + a + " домов"); }
            else
            {
                if (a % 10 == 2 || a == 2)
                {
                    Console.WriteLine("Мы построили " + a + " дома");

                }
                if (a % 10 == 3 || a == 3)
                {
                    Console.WriteLine("Мы построили " + a + " дома");
                    
                }
                if (a % 10 == 4 || a == 4)
                {
                    Console.WriteLine("Мы построили " + a + " дома");
                    
                }
                if (a % 10 == 5 || a == 5)
                {
                    Console.WriteLine("Мы построили " + a + " домов");
                    
                }
                if (a % 10 == 6 || a == 6)
                {
                    Console.WriteLine("Мы построили " + a + " домов");
                    
                }
                if (a % 10 == 7 || a == 7)
                {
                    Console.WriteLine("Мы построили " + a + " домов");
                    
                }
                if (a % 10 == 8 || a == 8)
                {
                    Console.WriteLine("Мы построили " + a + " домов");
                    
                }
                if (a % 10 == 9 || a == 9)
                {
                    Console.WriteLine("Мы построили " + a + " домов");
                    
                }
            }
            
        }
        static void Task3_11()
        {
            Console.WriteLine("Задание 11");
            Console.WriteLine("Размеры участка");
            int aS = Convert.ToInt32(Console.ReadLine());
            int bS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Размеры первого здания");
            int aB1 = Convert.ToInt32(Console.ReadLine());
            int bB1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Размеры втрого здания");
            int aB2 = Convert.ToInt32(Console.ReadLine());
            int bB2 = Convert.ToInt32(Console.ReadLine());

            if ((Math.Max(aB1, bB1) > Math.Max(aS, bS) || Math.Min(aB1, bB1) > Math.Min(aS, bS)) || (Math.Max(aB2, bB2) > Math.Max(aS, bS) || Math.Min(aB2, bB2) > Math.Min(aS, bS)))
            {
                Console.WriteLine("Net");

            }
            if (Math.Max(aS, bS) - Math.Max(aB1, bB1) >= Math.Max(aB2, bB2) || Math.Min(aS, bS) - Math.Min(aB1, bB1) >= Math.Min(aB2, bB2))
            {
                Console.WriteLine("da");

            }
            else
            {
                if (Math.Min(aS, bS) >= Math.Max(aB1, bB1) && Math.Max(aS, bS) - Math.Min(aB1, bB1) >= Math.Max(aB2, bB2))
                {
                    Console.WriteLine("da");

                }
                else
                {
                }
                if (Math.Max(aS, bS) - Math.Max(aB1, bB1) >= Math.Min(aB2, bB2) && Math.Min(aS, bS) >= Math.Max(aB2, bB2))
                {
                    Console.WriteLine("da");

                }
                else
                {
                    Console.WriteLine("Net");
                }
            }
        }
    }
}
