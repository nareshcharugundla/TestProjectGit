using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 4, 7, 1, 9, 5 };
            int target = 8;

            for(int i = 0; i < a.Length; i++)
            {
                if((a[i]+a[i+1]) == target)
                {
                    Console.WriteLine($"The two indices are {i}{i++}");
                }
            }

        }
    }
}
