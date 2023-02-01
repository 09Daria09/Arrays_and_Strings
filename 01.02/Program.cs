using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

                int sizeOfArray = 100;

                Random r = new Random();
                int[] array = new int[sizeOfArray];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = r.Next(1, 10);
                    Console.Write("{0}|", array[i]);
                }

                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if(numbers[0] == array[i] && numbers[1] == array[i+1] && numbers[2] == array[i+2])
                    {
                        count++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Количество повторений компинации {0}|{1}|{2} -> {3}", numbers[0], numbers[1], numbers[2], count);
            }
            #endregion

        }
    }
}
