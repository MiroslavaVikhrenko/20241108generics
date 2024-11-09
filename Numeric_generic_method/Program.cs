using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_generic_method
{
    //Разработчику необходимо написать обобщенный метод, который может работать с любой коллекцией,
    //но он хочет ограничить этот метод только коллекциями, содержащими элементы числового типа.
    //Он не знает, как этого добиться, не ограничивая метод.
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static T Sum<T>(T x, T y) where T : INumber<T>
        {

        }
    }
}
