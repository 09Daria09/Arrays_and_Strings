using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01._02
{

    class Average
    {
        static void Main(string[] args)
        {
            Console.Write("Введите задание, которое хотите проверить: ");
            string test = Console.ReadLine();

            #region перебор массива через foreach
            if (test == "0")
            {
                int count = 10;

                Random r = new Random();
                int[] a = new int[count];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = r.Next(1, 20);
                }

                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine();
            }
            #endregion
            #region уникальные элементы массива
            if (test == "1")
            {
                int count = 20;

                Random r = new Random();
                int[] array = new int[count];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = r.Next(1, 100);
                    Console.Write("{0}|", array[i]);
                }

                int even = 0;
                int odd = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] == array[j] && i == j)
                        {
                            break;
                        }
                        else
                        {
                            if (array[i] % 2 == 0)
                            {
                                even++;
                                break;
                            }
                            else
                            {
                                odd++;
                                break;
                            }

                        }
                    }
                }
                Console.WriteLine("Количество четный чисел в массиве составляет: {0}", even);
                Console.WriteLine("Количество нечетный чисел в массиве составляет: {0}", odd);
            }
            #endregion
            #region значения меньше указаного пользователем
            if (test == "2")
            {
                int size = 20;

                Random r = new Random();
                int[] array = new int[size];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = r.Next(1, 100);
                    Console.Write("{0}|", array[i]);
                }

                Console.WriteLine();
                Console.Write("Введите число: ");
                int num = Convert.ToInt32(Console.ReadLine());

                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (num > array[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine("Количество значений в массиве меньше {0} -> {1}", num, count);
            }
            #endregion
            #region последовательность трех чисел
            if (test == "3")
            {
                int size = 3;
                int[] numbers = new int[size];

                Console.Write("Введите последовательность трех чисел: ");
                string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < (size < str.Length ? size : str.Length); ++i)
                    numbers[i] = Convert.ToInt32(str[i]);

                int sizeOFirst = 100;

                Random r = new Random();
                int[] array = new int[sizeOFirst];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = r.Next(1, 10);
                    Console.Write("{0}|", array[i]);
                }

                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (numbers[0] == array[i] && numbers[1] == array[i + 1] && numbers[2] == array[i + 2])
                    {
                        count++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Количество повторений компинации {0}|{1}|{2} -> {3}", numbers[0], numbers[1], numbers[2], count);
            }
            #endregion
            #region третий массив общих элементов 
            if (test == "4")
            {
                Console.Write("Первый массив ->");
                int M = 20;
                Random r1 = new Random();
                int[] First = new int[M];
                for (int i = 0; i < First.Length; i++)
                {
                    First[i] = r1.Next(1, 100);

                    Console.Write("{0}|", First[i]);
                }

                Console.WriteLine();
                Console.Write("Второй массив ->");
                int N = 20;
                int[] Second = new int[N];
                for (int i = 0; i < Second.Length; i++)
                {
                    Second[i] = r1.Next(1, 100);
                    Console.Write("{0}|", Second[i]);
                }

                Console.WriteLine();
                Console.Write("Третий массив ->");
                int size = 0;
                for (int i = 0; i < First.Length; i++)
                {
                    for (int j = 0; j < Second.Length; j++)
                    {
                        if (First[i] == Second[j])
                        {
                            size++;
                        }
                    }
                }

                int[] Third = new int[size];
                int index = 0;
                for (int i = 0; i < First.Length; i++)
                {
                    for (int j = 0; j < Second.Length; j++)
                    {
                        if (First[i] == Second[j])
                        {
                            Third[index] = First[i];
                            Console.Write("{0}|", Third[index]);
                            index++;
                            Array.Clear(First, i, 1);
                        }
                    }
                }
                Console.WriteLine();
            }
            #endregion
            #region минимальное и максимальное значение в двумерном массиве
            if (test == "5")
            {

                Random r1 = new Random();
                int[,] A = new int[5, 5];
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        A[i, j] = r1.Next(1, 100);
                        Console.Write("{0}|", A[i, j]);
                    }
                    Console.WriteLine();
                }

                int min = A[0, 0];
                int max = A[0, 0];

                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        if (min > A[i, j])
                        {
                            min = A[i, j];
                        }
                        if (max < A[i, j])
                        {
                            max = A[i, j];
                        }
                    }
                }
                Console.Write($"Минимальное значение -> {min} \nМаксимальное значение -> {max}\n");
            }
            #endregion
            #region подсчет слов
            if (test == "6")
            {
                Console.Write("Введите предложение: ");
                string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

                int count = str.Length;
                Console.Write($"Количество слов -> {count}\n");

            }
            #endregion
            #region переворот слова
            if (test == "7")
            {

                Console.Write("Введите слово: ");
                string str = Console.ReadLine();

                StringBuilder sb = new StringBuilder();

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    sb.Append(str[i]);
                }

                Console.WriteLine(sb.ToString());
            }
            #endregion
            #region количество гласных букв
            if(test == "8")
            {
                Console.Write("Введите предложение: ");
                string str = Console.ReadLine();

                int count = Regex.Matches(str, @"[ауоыиэяюёе]", RegexOptions.IgnoreCase).Count;
                Console.WriteLine($"Количество гласных  букв: {count}");
            }
            #endregion 
            #region поиск подстроки в строке
            if(test == "9")
            {
                Console.Write("Введите предложение: ");
                string str = Console.ReadLine();

                Console.Write("Введите слово: ");
                string word = Console.ReadLine();

                int amount = new Regex(word).Matches(str).Count;
                Console.WriteLine($"Количество подстроки в строке: {amount}");
            }
            #endregion 

        }
    }
}
