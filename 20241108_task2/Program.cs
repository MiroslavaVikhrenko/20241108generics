using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20241108_task2
{
    //Создать универсальный класс Number, установить ограничение на принятия только типа данных int.
    //Создать объект класса, принять число типа int.
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseNumber<int> bn1 = new BaseNumber<int>(10, 15);
            bn1.Info();
            Number<BaseNumber<int>> n1 = new Number<BaseNumber<int>>(bn1);
            n1.Sum();
            n1.Mult();

            BaseNumber<int> bn2 = new BaseNumber<int>(3, -7);
            bn2.Info();
            Number<BaseNumber<int>> n2 = new Number<BaseNumber<int>>(bn2);
            n2.Sum();
            n2.Mult();

            BaseNumber<int> bn3 = new BaseNumber<int>(-100, 23);
            bn3.Info();
            Number<BaseNumber<int>> n3 = new Number<BaseNumber<int>>(bn3);
            n3.Sum();
            n3.Mult();

            Console.ReadLine();
        }
    }

    public class BaseNumber<T> where T : struct
    {
        public T Value1 { get; set; }
        public T Value2 { get; set; }

        public BaseNumber(T value1, T value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public void Info()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Number 1: {Value1}, number 2: {Value2}");
            Console.ResetColor();
        }
    }
    public class Number<T> where T : BaseNumber<int>
    {
        public BaseNumber<int> Numbers { get; set; }
        public Number(BaseNumber<int> numbers)
        {
            Numbers = numbers;
        }

        public void Sum()
        {
            Console.WriteLine($"SUM: {Numbers.Value1} + {Numbers.Value2} = {Numbers.Value1 + Numbers.Value2}");
        }
        public void Mult()
        {
            Console.WriteLine($"MULT: {Numbers.Value1} * {Numbers.Value2} = {Numbers.Value1 * Numbers.Value2}");
        }
    }
}
