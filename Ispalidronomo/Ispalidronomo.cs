using System;
using System.Collections.Generic;
using System.Text;

namespace Ispalidronomo
{
    internal class Ispalidronomo
    {
        public void Espalidronomo(int x)
        {
            string number = x.ToString();
            bool result = false;
            for (var i = 0; i < number.Length; i++)
            {
                for (var j = number.Length - 1; j >= 0; j--)
                {
                    if (number[j] == number[i])
                    {
                        result = true;

                    }
                    else
                    {
                        result = false;
                        break;

                    }
                    i++;
                }
                break;
            }
            Console.WriteLine("Is Palindromo");
            Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}
