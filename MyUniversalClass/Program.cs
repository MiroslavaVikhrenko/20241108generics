using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUniversalClass
{
    //Разработать собственный универсальный класс, содержащий метод для вычисления наименьших значений
    //элементов строк матрицы размера [m, n]. Результатом должен быть одномерный массив, размерностью [m].
    //Матрица может иметь любой тип данных.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {{1, 2, 3, 4}, {5, 6, 7, 0}, {8, 9, 10, 7}, { 10, 9, 11, 0 } };
            int[] newmatrix = MyMethod(matrix);
            PrintMatrix(newmatrix);

            Console.ReadKey();
        }

        //static public T[] MyMethod<T>(T[,] matrix) where T : struct , IEquatable<T>
        //{
        //    T[] newmatrix = new T[matrix.GetLength(0)];
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        T min = matrix[i, 0];
        //        for (int j = 0;  j < matrix.GetLength(1); j++)
        //        {
        //            if (matrix[i, j] < min)
        //            {
        //                min = matrix[i, j];
        //            }
        //        }
        //        newmatrix[i] = min;
        //    }
        //    return newmatrix;
        //}

        static void PrintMatrix(int[] matrix)
        {
            for (int i  = 0; i < matrix.Length; i++)
            {
                Console.WriteLine($" {matrix[i]} ");
            }
        }
        static public int[] MyMethod(int[,] matrix) 
        {
            int[] newmatrix = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                newmatrix[i] = min;
            }
            return newmatrix;
        }
    }

}
