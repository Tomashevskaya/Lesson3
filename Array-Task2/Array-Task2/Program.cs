using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[6];
            for (int count = 0; count < nums.Length; count++)
            {
                nums[count] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in nums)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }
    }
}
