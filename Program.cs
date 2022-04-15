using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppXX
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            for(int i =0; i < num.Length; i++)
            {
                num[i] *= 2;
            }
            Console.WriteLine(string.Join(" ", num));
            Console.ReadKey();
            Console.Write("Введите число А");
            int[] num1 = { 1, 2, 3, 4, 5 };
            int A = int.Parse(Console.ReadLine());
            for(int i = 0; i < num1.Length;i++)
            {
                num1[i] -= A;
            }
            Console.WriteLine(string.Join(" ", num1));
            double[] num2 = { 1, 2, 3, 4, 5 };
            double B = num2[0];
            Console.WriteLine($"Числа поделены на {B}: ");
            for(int i = 0; i < num1.Length;i++)
            {
                num2[i] /= B;
            }
            Console.WriteLine(string.Join(" ", num2));
        }
    }
}
