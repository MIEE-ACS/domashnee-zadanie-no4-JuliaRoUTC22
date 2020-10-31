using System;

namespace Console_homework_4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Введите количество столбцов матрицы:");
                int w;
                Console.Write("w = ");

                if (Int32.TryParse(Console.ReadLine(), out w))
                {

                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Количество столбцов - целое неотрицательное число. Попробуйте снова.");
                    Console.Write($"w = ");
                    w = int.Parse(Console.ReadLine());

                }


                Console.WriteLine("Введите количество строк матрицы:");
                int h;
                Console.Write("h = ");

                if (Int32.TryParse(Console.ReadLine(), out h))
                {

                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Количество строк - целое неотрицательное число. Попробуйте снова.");
                    Console.Write($"h = ");
                    h = int.Parse(Console.ReadLine());

                }


                int[,] matrix = new int[h, w];
                Console.WriteLine("Прямоугольная матрица, заполненная случайными элементами:");

                Random rand = new Random();
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        matrix[i, j] = rand.Next();
                    }
                }

                for (int i = 0; i < h; ++i)
                {
                    for (int j = 0; j < w; ++j)
                    {
                        Console.Write("\t" + matrix[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.Write("Введите количество элементов для  сдвига: ");
                Console.Write($"n = ");

                int n;
                if (Int32.TryParse(Console.ReadLine(), out n))
                {

                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Количество элементов - целое число. Попробуйте снова.");
                    Console.Write($"n = ");
                    n = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Выберите режим сдвига:\n0 - вправо\n1 - вниз");
                Console.Write("Выбран режим сдвига: ");

                int shift;
                if (Int32.TryParse(Console.ReadLine(), out shift))
                {

                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Режим сдвига - 0 или 1. Попробуйте снова.");
                    Console.Write($"Выбран режим: ");
                    shift = int.Parse(Console.ReadLine());
                }


                int i2 = 0;
                int j2 = 0;

                if (shift == 0)
                {
                    Console.WriteLine("Циклический сдвиг вправо.\nПолученная матрица:");
                    int n1 = w - n % w;
                    for (int i = 0; i < h; ++i)
                    {
                        i2 = i;
                        for (int j = 0; j < w; ++j)
                        {
                            j2 = (j + n1) % w;
                            Console.Write("\t" + matrix[i2, j2]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"Осуществлён сдвиг вправо на n = {n} элементов.");
                }

                else if (shift == 1)
                {
                    Console.WriteLine("Циклический сдвиг вниз.\nПолученная матрица:");
                    int n2 = h - n % h;
                    for (int i = 0; i < h; ++i)
                    {
                        for (int j = 0; j < w; ++j)
                        {
                         
                            j2 = j;
                           i2 = (i + n2) % h;
                            Console.Write("\t" + matrix[i2, j2]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"Осуществлён сдвиг вниз на n = {n} элементов.");
                }

                else

                {
                    Console.WriteLine("Ошибка. Введите режим сдвига из предложенных вариантов.");

                   /* shift = int.Parse(Console.ReadLine());
                    if (shift == 0)
                    {
                        Console.WriteLine("Циклический сдвиг вправо.\nПолученная матрица:");
                        int n1 = w - n % w;
                        for (int i = 0; i < h; ++i)
                        {
                            i2 = i;
                            for (int j = 0; j < w; ++j)
                            {
                                j2 = (j + n1) % w;
                                Console.Write("\t" + matrix[i2, j2]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine($"Осуществлён сдвиг вправо на n = {n} элементов.");
                    }

                    else if (shift == 1)
                    {
                        Console.WriteLine("Циклический сдвиг вниз.\nПолученная матрица:");
                        int n2 = h - n % h;
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                Console.Write("\t" + matrix[i2, j2]);
                                j2 = j;
                                i2 = (i + n2) % h;
                                Console.Write("\t" + matrix[i2, j2]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine($"Осуществлён сдвиг вниз на n = {n} элементов.");
                    }*/
                }

            }

            catch
            {

                Console.WriteLine("Произошло исключение.");
            }
         }
    }
}
