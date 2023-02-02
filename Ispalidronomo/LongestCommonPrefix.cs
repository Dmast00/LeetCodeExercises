using System;
using System.Collections.Generic;
using System.Text;

namespace Ispalidronomo
{
    internal class LongestCommonPrefix
    {
        public  void Commons(string[] strs)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            string result = "";
            string prev = "";
            foreach (var str in strs)
            {
                for (var i = str.Length - 1; i >= 0; i--)
                {
                    if (prev != "" && prev.Contains(str[i]))
                    {
                        result += str[i];
                    }
                }
                prev = str;
            }
            Console.WriteLine("Longest");
            Console.WriteLine(result);

        }
    }
}
