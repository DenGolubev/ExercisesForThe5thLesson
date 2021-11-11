using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber rationalNumber;

            var numbers = EnterNumber();

            rationalNumber = new RationalNumber(numbers.Item1, numbers.Item2);
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Дробь - {rationalNumber}");
            Console.WriteLine($"Сложение - {rationalNumber.Numerator + rationalNumber.Denominator}");
            Console.WriteLine($"Вычитание - {rationalNumber.Numerator - rationalNumber.Denominator}");
            Console.WriteLine($"Умножение - {rationalNumber.Numerator * rationalNumber.Denominator}");
            Console.WriteLine($"Деление - {rationalNumber.Numerator / rationalNumber.Denominator}");
            Console.WriteLine($"Остаток от Деления - {rationalNumber.Numerator % rationalNumber.Denominator}");
            Console.WriteLine($"Постфиксный Инкримент - {rationalNumber++}");
            Console.WriteLine($"Постфиксный Декримент - {rationalNumber--}");
            Console.WriteLine($"Префиксный Инкримент - {++rationalNumber}");
            Console.WriteLine($"Префиксный Декримент - {--rationalNumber}");
            Console.WriteLine($"Равенство - {rationalNumber.Numerator == rationalNumber.Denominator}");
            Console.WriteLine($"Не равны - {rationalNumber.Numerator != rationalNumber.Denominator}");
            Console.WriteLine($"Числитель Больше Знаменателя - {rationalNumber.Numerator > rationalNumber.Denominator}");
            Console.WriteLine($"Числитель Меньше Знаменателя - {rationalNumber.Numerator < rationalNumber.Denominator}");
            Console.WriteLine($"Числитель Больше или равен Знаменателю - {rationalNumber.Numerator >= rationalNumber.Denominator}");
            Console.WriteLine($"Числитель Меньше или равен Знаменателю - {rationalNumber.Numerator <= rationalNumber.Denominator}");
            Console.WriteLine($"Преобразование float - {(float)rationalNumber}");

            Console.ReadKey();
        }

        static (int, int) EnterNumber()
        {
            Console.WriteLine("Введите числитель");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знаменатель");
            int n2 = Convert.ToInt32(Console.ReadLine());

            var numbers = (n1, n2);

            return numbers;
        }
    }
}
