using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_GenericTypes_Interface_homework
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] str = { "Salam", "Alma" };

            int[] numbers = { 5, 43, 2, 55 };

            double[] num = {1,0.7, 5, 5.4, 8 };
            foreach (var items in num)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("****Sorted array****");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }

        public static T Max<T>(T op1, T op2) where T : IComparable
        {
            if (op1.CompareTo(op2) < 0)
                return op1;
            return op2;
        }
        static void SortItems<T>(T[] items) where T : IComparable
        {
            int i, j;

            for (i = 1; i < items.Length; i++)
            {
                IComparable value = items[i];
                j = i - 1;
                while ((j >= 0) && (items[j].CompareTo(value) > 0))
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j + 1] = (T)value;
            }
        }
    }


}

