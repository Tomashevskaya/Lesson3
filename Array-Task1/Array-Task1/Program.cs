using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            for (int count = 0; count < nums.Length; count++)
            {
                nums[count] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(nums);
            foreach (int item in nums)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }
    }
}
          