using System;
namespace yyy
{
    class PleaseSayUA
    {
        static void Main()
        {
            double n, a, res;
            res = 0;
            Console.WriteLine("введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второе число");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите код операции");
            string ReadLine = Console.ReadLine();
            Calculator calculator = CalculatorFactory.Create(ReadLine);
            res = calculator.Calc(a, n);
            Console.WriteLine(res);
            Console.WriteLine("Ura!");
            Console.ReadLine();
        }
    }
}