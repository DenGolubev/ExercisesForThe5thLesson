using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = new ComplexNumber(9.125, 5.128);
            var number2 = new ComplexNumber(10.25, 7.54);

            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Число1 - {number1}");
            Console.WriteLine($"Число2 - {number2}");
            Console.WriteLine($"Сложение - {number1 + number2}");
            Console.WriteLine($"Вычитание - {number1 - number2}");
            Console.WriteLine($"Умножение - {number1 * number2}");
            Console.WriteLine($"Деление - {number1 / number2}");

            //Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
