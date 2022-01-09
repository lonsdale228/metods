using System;

namespace metods
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Иванов", "Иван");
            var person2 = new Person("Петров", "Петр");

            for (int i = 0; i < 10; i++)
            {
                var position1 = person1.Run(1);
                Console.WriteLine(position1);

                var position2 = person2.Run(1);
                Console.WriteLine();
            }

            Console.WriteLine(Factorial(10));
            Console.ReadLine();


            
        }

        public static int PrintHello(string name, int age)
            {
                Console.WriteLine($"Привет, {name}. Вам {age} лет");
                return 1;
            }

        public static int Factorial(int value)
        {
            if (value <= 1)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }

    }
}
    