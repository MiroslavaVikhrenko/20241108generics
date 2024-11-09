using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeric_generic_method_task
{
    internal class Program
    {
        //Разработчику необходимо написать обобщенный метод, который может работать с любой коллекцией,
        //но он хочет ограничить этот метод только коллекциями, содержащими элементы числового типа.
        //Он не знает, как этого добиться, не ограничивая метод.
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            //var result = Sum(array);

            //Console.WriteLine(result);
            Console.ReadLine();
        }

        //static T Sum<T>(IEnumerable<T> values) where T : INumber<T>
        //{
        //    T sum = default;

        //    foreach (var value in values)
        //    {
        //        sum += value;
        //    }

        //    return sum;
        //}
    }
}
