using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3___Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i = 2;
            bool simple = false;

            while (true)
            {
                Console.Write("Введите целое число: ");
                num = Convert.ToInt32(Console.ReadLine());

                if ((num % i == 0) & (i <= num - 1))
                {
                    simple = true;
                    Console.WriteLine("Число не является простым!");
                    i++;
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Число простое!");
                    Console.ReadKey();
                    break;
                }
                
            }
            }
        }
    }

