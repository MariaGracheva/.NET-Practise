﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    /// <summary>
    /// Вспомогательный класс для работы с матрицами.
    /// </summary>
    public static class MatrixHelper
    {
        /// <summary>
        /// Метод для вывода матрицы в консоль.
        /// </summary>
        /// <param name="matrix">Матрица, который нужно вывести.</param>
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
