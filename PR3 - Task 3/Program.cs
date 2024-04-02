using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            Console.Write("Введите целое число: ");
            num = Convert.ToInt32(Console.ReadLine());
            bool simple = false;
            if (num > 1)
            {
                while ((simple == false) & (i <= num - 1))
                {  
                    if ((num % i == 0))
                    {
                        simple = true;
                    } 
                    else if((num % i != 0))
                        {
                        simple = false;
                    }
                    i++;
                }
                if ((simple == true))
                {
                    Console.WriteLine("Число не является простым!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Число простое!");
                    Console.ReadKey();
                }
            }          
            else
            {
                Console.WriteLine("Число не является ни простым, ни составным!");
                Console.ReadKey();
                return;
            }
        }
    }
}

