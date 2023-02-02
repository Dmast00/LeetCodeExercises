using System;
using System.Collections.Generic;

namespace Ispalidronomo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Es el numero palindromo
            Ispalidronomo palindromo = new Ispalidronomo();
            palindromo.Espalidronomo(1000021);
            
            //Numeros que den la suma del target
            TwoSum twosum = new TwoSum();
            int[] array = { 3, 2, 4 };
            twosum.dosSumas(array,6);

            LongestCommonPrefix lng = new LongestCommonPrefix();
            string[] commmon = { "flower", "flow", "flight" };
            lng.Commons(commmon);
        }

        
        

        

   
    }
}
