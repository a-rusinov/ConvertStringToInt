using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("Введите значение первого числа...");
                string s = Console.ReadLine();
                Console.WriteLine("Введите значение второго числа...");
                string s1 = Console.ReadLine();
                Console.WriteLine("Введите значение третьего числа...");
                string s2 = Console.ReadLine();



                Console.WriteLine("Выполняется операция на числами...");
                int a = Convert.ToInt32(s);
                int a1 = Convert.ToInt32(s1);
                int a2 = Convert.ToInt32(s2);
                int Summ = a * a1 ^ a2;

                //Console.ReadKey();

                Console.WriteLine("езультат операции на числами..." + Summ);
                Console.ReadKey();
            }
            catch (ArithmeticException AE)
            {

                Console.WriteLine(AE.Message);
                Console.ReadKey();
                // throw;
            }


           



        }
    }
}
