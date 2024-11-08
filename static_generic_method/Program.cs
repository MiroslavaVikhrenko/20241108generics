using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_generic_method
{
    //Напишите программу, в которой есть статический обобщенный метод. Метод не возвращает результат,
    //а аргументом методу передается массив с элементами обобщенного типа.
    //При вызове метода выполняется циклическая перестановка элементов массива:
    //первый элемент становится вторым, второй элемент становится третьим, и так далее,
    //а последний элемент становится первым.
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> a1 = new MyArray<int>(new int[]{ 0, 1, 2, 3, 4, 5 });
            PrintArray(a1);
            Swap(a1);
            PrintArray(a1);

            MyArray<bool> a2 = new MyArray<bool>(new bool[] { false, true, true, true, false });
            PrintArray(a2);
            Swap(a2);
            PrintArray(a2);

            MyArray<DateTime> a3 = new MyArray<DateTime>(new DateTime[] { new DateTime(2024, 10, 10), new DateTime(2023, 1, 1) , new DateTime(2022, 5, 5) , new DateTime(2021, 2, 2), new DateTime(2020, 7, 7) });
            PrintArray(a3);
            Swap(a3);
            PrintArray(a3);

            MyArray<char> a4 = new MyArray<char>(new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g' });
            PrintArray(a4);
            Swap(a4);
            PrintArray(a4);

            Console.ReadLine();

        }
        static void Swap<T>(MyArray<T> array) where T : struct
        {
            var temp = array.Values[array.Values.Length - 1];
            Array.Copy(array.Values, 0, array.Values, 1, array.Values.Length - 1);
            array.Values[0] = temp;
        }

        static void PrintArray<T>(MyArray<T> array) where T : struct
        {
            Console.WriteLine();
            for (int i = 0; i < array.Values.Length; i++)
            {
                Console.Write($" {array.Values[i]} ");
            }
        }
    }

    public class MyArray<T>
    {
        public T[] Values { get; set; }

        public MyArray(T[] array)
        {
            Values = array;
        }
    }
}
