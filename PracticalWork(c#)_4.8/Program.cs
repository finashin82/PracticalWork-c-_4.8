using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_c___4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1. Случайная матрица

            Console.WriteLine("Задание 1. Случайная матрица.");
            Console.WriteLine();

            int numbRow1, numbCol1, sumElements = 0;
            int[,] randMatrix;
            Random random1 = new Random();

            Console.Write("Введите количество строк в матрице: ");
            numbRow1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            numbCol1 = Convert.ToInt32(Console.ReadLine());

            randMatrix = new int[numbRow1, numbCol1];

            for (int i = 0; i < numbRow1; i++)
            {
                for (int j = 0; j < numbCol1; j++)
                {
                    randMatrix[i, j] = random1.Next(10);
                    Console.Write($"{randMatrix[i, j],2} ");
                    sumElements += randMatrix[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма элементов массива = {sumElements}");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            #region Задание 2. Сложение матриц

            Console.WriteLine("Задание 2. Сложение матриц.");
            Console.WriteLine();

            int numbRow2, numbCol2;
            int[,] randMatrixA, randMatrixB, sumMatrix;
            Random random2 = new Random();

            Console.Write("Введите количество строк в матрицах: ");
            numbRow2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрицах: ");
            numbCol2 = Convert.ToInt32(Console.ReadLine());


            randMatrixA = new int[numbRow2, numbCol2];
            randMatrixB = new int[numbRow2, numbCol2];
            sumMatrix = new int[numbRow2, numbCol2];

            Console.WriteLine("Матрица А:");
            for (int i = 0; i < numbRow2; i++)
            {
                for (int j = 0; j < numbCol2; j++)
                {
                    randMatrixA[i, j] = random2.Next(10);
                    Console.Write($"{randMatrixA[i, j],2}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Матрица B:");
            for (int i = 0; i < numbRow2; i++)
            {
                for (int j = 0; j < numbCol2; j++)
                {
                    randMatrixB[i, j] = random2.Next(10);
                    Console.Write($"{randMatrixB[i, j],2}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Сумма матрица А+В:");
            for (int i = 0; i < numbRow2; i++)
            {
                for (int j = 0; j < numbCol2; j++)
                {
                    sumMatrix[i, j] = randMatrixA[i, j] + randMatrixB[i, j];
                    Console.Write($"{sumMatrix[i, j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
            #endregion
        }
    }
}
