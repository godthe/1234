using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HomeWork2
{
    class Program
    {
        // Пузырьковая сортировка
        static void BubbleSort(int[] arr, int n)
		{
            int temp;
		    for (int i = 0; i < n-1; i++)
		    {
		        for (int j = i + 1; j < n; j++)
		        {
		            if (arr[j] < arr[i])
		            {
		                temp = arr[i];
		                arr[i] = arr[j];
		                arr[j] = temp;
		            }
		        }
		    }
		}

        // Сортировка вставками
        static void InsertionSort(int[] arr, int n)
        {
            int current, j;
            for (int i = 1; i < n; i++)
            {
                current = arr[i];
                j = i;
                while (j > 0 && current < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = current;
            }
        }

        // Сортировка выбором
        static void SelectionSort(int[] arr, int n)
        {
            int min, temp, i, j;
            for (i = 0; i < n - 1; i++)
            {
                min = i;
                for (j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }

        // Сортировка Шелла
        static void ShellSort(int[] arr, int n)
        {
            int j, i;
            int step = n / 2;
            while (step > 0)
            {
                for (i = 0; i < (n - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (arr[j] > arr[j + step]))
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + step];
                        arr[j + step] = tmp;
                        j-=step;
                    }
                }
                step = step / 2;
            }
        }

        // Гномья сортировка
        static void GnomeSort(int[] arr, int n)
        {
            int i = 1, temp;
            while (i < n)
            {
                if (i == 0 || arr[i - 1] <= arr[i])
                    i++;
                else
                {
                    temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                    i--;
                }
            }
        }

        // Глупая сортировка
        static void StupidSort(int[] arr, int n)
        {
            int i = 0;
            int tmp;
            while (i < n - 1)
            {
                if (arr[i + 1] < arr[i])
                {
                    tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                    i = 0;
                }
                else
                    i++;
            }
        }

        // Сортировка чет-нечет
        static void OddEvenSort(int[] arr, int n)
        {
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 2; j < n; j += 2)
                        if (arr[j] < arr[j - 1])
                        {
                            temp = arr[j];
                            arr[j] = arr[j - 1];
                            arr[j - 1] = temp;
                        }
                }
                else
                {
                    for (int j = 1; j < n - 1; j += 2)
                        if (arr[j] < arr[j - 1])
                        {
                            temp = arr[j];
                            arr[j] = arr[j - 1];
                            arr[j - 1] = temp;
                        }
                }
            }
        }

		static void PrintArray(string message, int[] A)
		{
			Console.WriteLine(" " + message + ": ");
			for (int i = 0; i < A.Length; i++)
			{
                Console.WriteLine("  " + A[i].ToString());
			}
			Console.WriteLine();
		}

        // Подсчет средней оценки и оценки выше средней
        static void CalculateMarks()
        {
            int i, N, best;
            int[] mark = new int[100];
            float sum, avrg;
            Console.WriteLine(" Введите количество оценок:");
            N = Int32.Parse(Console.ReadLine());
            sum = 0;
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(" Введите оценку № " + (i + 1));
                mark[i] = Int32.Parse(Console.ReadLine());
                sum = sum + mark[i];
            }
            avrg = sum / N;
            best = 0;
            for (i = 0; i < N; i++)
                if (mark[i] > avrg)
                    best = best + 1;
            Console.WriteLine("Средняя оценка: " + avrg);
            Console.WriteLine("Оценок выше средней: " + best);
        }

        // Транспонирование матрицы
        static void TransposeMatrix()
        {
            int i, j, M, N;
            float[,] a = new float[10, 10];
            Console.WriteLine(" Введите количество строк:");
            M = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Введите количество столбцов:");
            N = Int32.Parse(Console.ReadLine());
            if ((M < 1) || (M > 10) || (N < 1) || (N > 10))
            {
                Console.WriteLine(" Параметры матрицы заданы некорректно");
                return;
            }
            Console.WriteLine(" Исходная матрица размера " + M + " на " + N + ":");
            for (i = 0; i < M; i++)
                for (j = 0; j < N; j++)
                {
                    Console.WriteLine(" Введите элемент [" + (i+1) + " " + (j+1) + "]:");
                    a[i, j] = Int32.Parse(Console.ReadLine());
                }
            Console.WriteLine(" Транспонированная матрица размера " + M + " на " + N + ":");
            for (j = 0; j < N; j++)
            {
                for (i = 0; i < M; i++)
                    Console.Write(" " + a[i, j] + ". ");
                Console.WriteLine();
            }
        }

        // Решение квадратного уравнения
        static void QuadraticEquation()
        {
            double A, B, C, D, SD, X1, X2, X;
            Console.WriteLine(" A");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine(" B");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine(" C");
            C = float.Parse(Console.ReadLine());
            if (A != 0)
            {
                D = B*B - 4*A*C;
                if (D >= 0)
                {
                    SD = Math.Sqrt(D);
                    X1 = (-B + SD) / (2 * A);
                    X2 = (-B - SD) / (2 * A);
                    Console.WriteLine("Корни уравнения X1=" + X1 + " X2=" + X2);
                }
                else
                {
                    Console.WriteLine("Действительных корней нет");
                    return;
                }
            }
            else
                if (B != 0)
                {
                    X = -C/B;
                    Console.WriteLine("Корень уравнения X = " + X);
                    return;
                }
                else
                    if (C != 0)
                        Console.WriteLine("Действительных корней нет");
                    else
                        Console.WriteLine("Корень - любое число");
        }
        static void Main(string[] args)
        {
			int[] Array = new int[] {4, 9, 1, 4, 3};
            int[] BubbleSortArray = new int[] {4, 9, 1, 4, 3};
            int[] InsertionSortArray = new int[] {4, 9, 1, 4, 3};
            int[] SelectionSortArray = new int[] {4, 9, 1, 4, 3};
            int[] ShellSortArray = new int[] {4, 9, 1, 4, 3};
            int[] CocktailSortArray = new int[] {4, 9, 1, 4, 3};
            int[] GnomeSortArray = new int[] {4, 9, 1, 4, 3};
            int[] CombSortArray = new int[] {4, 9, 1, 4, 3};
            int[] HeapSortArray = new int[] {4, 9, 1, 4, 3};
            int[] QuickSortArray = new int[] {4, 9, 1, 4, 3};
            int[] StupidSortArray = new int[] {4, 9, 1, 4, 3};
            int[] OddEvenSortArray = new int[] {4, 9, 1, 4, 3};
			PrintArray("Исходный массив", Array);
			BubbleSort(BubbleSortArray, BubbleSortArray.Length);
			PrintArray("Сортировка пузырьком", BubbleSortArray);
            InsertionSort(InsertionSortArray, InsertionSortArray.Length);
			PrintArray("Сортировка вставками", InsertionSortArray);
            SelectionSort(SelectionSortArray, SelectionSortArray.Length);
			PrintArray("Сортировка выбором", SelectionSortArray);
            ShellSort(ShellSortArray, ShellSortArray.Length);
			PrintArray("Сортировка Шелла", ShellSortArray);
            GnomeSort(GnomeSortArray, GnomeSortArray.Length);
            PrintArray("Гномья сортировка", GnomeSortArray);
            StupidSort(StupidSortArray, StupidSortArray.Length);
            PrintArray("Глупая сортировка", StupidSortArray);
            OddEvenSort(OddEvenSortArray, OddEvenSortArray.Length);
            PrintArray("Сортировка чет-нечет", OddEvenSortArray);

            // Подсчет средней оценки и оценки выше средней
            //CalculateMarks();

            // Транспонирование матрицы
            //TransposeMatrix();

            // Решение квадратного уравнения
            //QuadraticEquation();
        }
    }
}