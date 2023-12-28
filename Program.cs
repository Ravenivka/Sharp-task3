using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Maximka(int number)
        {
            int A = number / 10;
            int B = number % 10;
            if (A > B)
            {
                return A;
            }else if(A==B)
            {
                return A;
            }
            else
            {
                return B;
            }
        }
        static void Main()
        {
            Console.WriteLine("Введите целое число из отрезка [10, 99]");
            int N = Int32.Parse(Console.ReadLine());
            string msg = "Наибольшая цифра: " + Maximka(N);
            Console.WriteLine(msg);
        }
    }
}
