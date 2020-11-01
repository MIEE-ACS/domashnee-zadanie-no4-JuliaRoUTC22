using System;

namespace Console_homework_4
{
    class Program
    {

            static void Main(string[] args)
      {
            try
            {

                Console.WriteLine("Введите количество элементов одномерного массива:");
                int n;
                Console.Write("n = ");

                if (Int32.TryParse(Console.ReadLine(), out n))
                {  
                    Console.WriteLine($"Заполняем массив из {n} случайных вещественных чисел.");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Количество элементов - целое неотрицательное число. Попробуйте снова.");
                    Console.Write($"n = ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Заполняем массив из {n} случайных вещественных чисел.");
                }


                if (n < 0)
                    Console.WriteLine("Некорректный ввод. Количество элементов должно быть неотрицательным.");

                if (n == 0)
                    Console.WriteLine("Некорректный ввод. Массив нулевой длины не подходит для данной задачи.");

                if (n > 0)
                {

                    double[] array = new double[n];

                    Random rand = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        array[i] = rand.NextDouble() * 1.7 - 1;
                        Console.WriteLine(array[i]);
                    }

                    /* 
                      //ввод массива с клавиатуры
                     Console.WriteLine("Введите элементы массива:");
                      for (int i = 0; i < n; i++)
                      {
                         Console.WriteLine($"array[{i}] = ");
                         array[i] = double.Parse(Console.ReadLine());
                      }
                    */

                    Console.WriteLine("Введите A:\nA = ");
                    double A;
                 
                     if (Double.TryParse(Console.ReadLine(), out A))
                     {

                     }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. A - число. Попробуйте снова.");
                        Console.Write($"A = ");
                        A = double.Parse(Console.ReadLine());

                    }

                    Console.Write("Введите B:\nB = ");                   
                    double B;
                     if (Double.TryParse(Console.ReadLine(), out B))
                     {

                     }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. B - число. Попробуйте снова.");
                        Console.Write($"B = ");
                        B = double.Parse(Console.ReadLine());

                    }

                    double max = 0;
                    int index = 0;
                    int quantity = 0;
                    double sum = 0;
                    for (int i = 0; i < n; i++)
                    {

                        if (i == 0)
                            max = array[0];
                        else if (array[i] > max)
                        {
                            max = array[i];
                            index = i;
                        }
                        else if (array[i] == max)
                        {
                            Console.WriteLine("В массиве два равных максимальных элемента.");

                        }

                        if ((array[i] > A) && (array[i] < B))
                            quantity++;
                    }
                    Console.WriteLine($"Количество элементов массива, лежащих в диапазоне от А до В: {quantity}");

                    for (int i = (index + 1); i < n; i++)
                        sum += array[i];
                    Console.WriteLine($"Сумма элементов массива, расположенных после максимального элемента: {sum}");


                    /*  for (int i = 0, j = 1; i < n; i++)
                          // for (int j = (n - 1); j > i; j--)
                          if (Math.Abs(array[i]) < Math.Abs(array[j]))
                          {
                              double t = array[i];
                              array[i] = array[j];
                              array[j] = t;
                              j++;
                          }*/


                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int j = 0; j < n - 1; j++)
                        {
                            if (Math.Abs(array[j]) < Math.Abs(array[j + 1]))
                            {
                                double tmp = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = tmp;
                            }
                        }
                    }


                    Console.WriteLine("Упорядоченные по убыванию модуля элементы массива:");
              
                    for (int i = 0; i < n; i++)             
                    Console.WriteLine(array[i]);
                }
            }


            catch
            {
             Console.WriteLine("Произошло исключение.");
            }


        }

    }
}
         
