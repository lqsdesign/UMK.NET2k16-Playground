using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq
{
    public class Kata
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            int[] result = new int[2];
            try
            {
                result[0] = input.Count(x => x > 0);
                result[1] = input.Sum(x => (x < 0 ? x : 0));
                return result;
            }
            catch
            {
                return result;
            }
        }
    }


}