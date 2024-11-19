namespace ConsoleApp20
{
    using System;

    namespace Lecture8.Example1
    {
        class Program
        {
            // Універсальний метод для обміну даними
            static void Swap<T>(ref T lhs, ref T rhs)
            {
                T temp;
                temp = lhs;
                lhs = rhs;
                rhs = temp;
            }

            static void Main(string[] args)
            {
                // Приклад обміну цілих чисел
                int a = 1;
                int b = 2;
                Swap<int>(ref a, ref b);
                Console.WriteLine($"Цілі числа: a={a} b={b}");

                // Приклад обміну типу double
                double x = 1.5;
                double y = 2.5;
                Swap<double>(ref x, ref y);
                Console.WriteLine($"Тип double: x={x} y={y}");

                // Приклад обміну рядків
                string str1 = "Hello";
                string str2 = "World";
                Swap<string>(ref str1, ref str2);
                Console.WriteLine($"Рядки: str1={str1} str2={str2}");

                Console.ReadKey();
            }
        }
    }

}
