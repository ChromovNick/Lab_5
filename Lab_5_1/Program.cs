using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы одномерного массива N= 7,1");
            int N = 7;
            int[] array = new int[7];
            float average = 0;
            for (int i = 0; i < N; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (float a in array)
            {
                average += (a / N);
            }
            Console.WriteLine("Cреднее арифметическое равняется {0:f2}", average);
            Console.ReadKey();
        }

   
    }
}
