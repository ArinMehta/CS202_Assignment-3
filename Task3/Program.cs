using System;

namespace Task3
{
    class Program
    {
        static void Main() {
            BubbleSort();

            Console.WriteLine();
            Flattenarray();

            Console.WriteLine();
            matrixmultiplication();
        }

        static void BubbleSort() {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++) {
                for (int j = 0; j < n - i - 1; j++) {
                    if (arr[j] > arr[j + 1]) {
                        arr[j] = arr[j] ^ arr[j + 1];
                        arr[j + 1] = arr[j] ^ arr[j + 1];
                        arr[j] = arr[j] ^ arr[j + 1];
                    }
                }
            }

            Console.WriteLine("Array sorted using Bubble Sort:");
            Console.WriteLine("Sorted array:");

            foreach (var item in arr) {
                Console.Write(item + " ");
            }
        }

        static void Flattenarray() {
            int[,] twoDArray = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int rows = twoDArray.GetLength(0);
            int cols = twoDArray.GetLength(1);

            int[] rowMajor = new int[rows * cols];
            int[] colMajor = new int[rows * cols];

            // Row-major
            int index = 0;
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    rowMajor[index++] = twoDArray[i, j];
                }
            }

            // Column-major
            index = 0;
            for (int i = 0; i < cols; i++) {
                for (int j = 0; j < rows; j++) {
                    colMajor[index++] = twoDArray[j, i];
                }
            }
            
            Console.WriteLine("\nRow-major flattened array:");
            foreach (var item in rowMajor) {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nColumn-major flattened array:");
            foreach (var item in colMajor) {
                Console.Write(item + " ");
            }
        }

        static void matrixmultiplication() {
            int[,] matrixA = {
                {1, 2, 3},
                {4, 5, 6}
            };

            int[,] matrixB = {
                {7, 8},
                {9, 10},
                {11, 12}
            };

            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            if (colsA != rowsB) {
                Console.WriteLine("Matrix multiplication not possible.");
                return;
            }

            int[,] C = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++) {
                for (int j = 0; j < colsB; j++) {
                    for (int k = 0; k < colsA; k++) {
                        C[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            Console.WriteLine("\nResultant Matrix after multiplication:");
            for (int i = 0; i < rowsA; i++) {
                for (int j = 0; j < colsB; j++) {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}