using System;

namespace TP1
{
    class Start
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");
            int number =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Exo1");
            tableOf(number);
            
            Console.WriteLine("Exo2.1");
            prime_number(number);

            Console.WriteLine("Exo2.2");
            fibo(number);

            Console.WriteLine("Exo2.3");
            Factorial(number);

            Console.WriteLine("Exo3");
            Ftry(number);

            Console.WriteLine("Please enter n :");
            Console.WriteLine("Please enter m :");
            square(n,m);



            // for (int i1 = 1; i1 < 11; i1++)
            // {
            //     for (int i2 = 1; i2 < 11; i2++)
            //     {
            //         if (i1*i2 % 2 == 1)
            //         {
            //             Console.WriteLine(i1 + "x" + i2 + "=" + i1*i2);
            //         }
            //     }
            // }
        }
        public static void tableOf(int n)
        {
            for (int i = 1; i < 11; i++)
            {
                if (n*i % 2 == 1)
                {
                    Console.WriteLine(n + "x" + i + "=" + n*i);
                }
            }
        }

        public static void prime_number(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n%i == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        public static int fibo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return fibo(n-1) = fibo(n-2);
            }
        }

        public static double Factorial(int number)    
        {    
            if (number == 0){
                return 1; 
            } 
            else
            {
                return number * Factorial(number-1);
            } 
        }

        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        public static void Ftry(int n)
        {
            for (int i = -3; i < 4; i++)
            {
                int x = PowerFunction(i);
                try
                {
                    int result = 10 / i;
                }
                catch ()
                {
                    Console.WriteLine("Error function try");
                }
            }
        }

        public static void square(int n, int m)
        {
            Console.WriteLine(n * "_");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("|" + n * " " + "|")
            }
            Console.WriteLine(n * "_");
        }

        public static void Doge()
        {
            using(StreamReader r = new StreamReader("DOGE_AllDataPoints_3Days.json"));
            {
                string jsonString = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(jsonString);
            }
            foreach (var item in r)
            {
                Console.WriteLine(item.config, item.usage, item.data);
            }
        }
    }
}