using System;
using System.Collections.Generic;
using System.Text;

namespace Ispalidronomo
{
    internal class TwoSum
    {
        public  void dosSumas(int[] nums, int target)
        {
            int[] array = new int[2];
            bool flag = false;

            for (var i = 0; i < nums.Length; i++)
            {
                if (flag == true) { break; }
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        array[0] = i;
                        array[1] = j;
                        flag = true;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine("Dos sumas"); 
            Console.WriteLine(string.Join("\n", array));
            Console.ReadKey(true);
        }
    }
}
