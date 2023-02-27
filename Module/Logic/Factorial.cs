using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Module.Logic
{
    public  class Factorial
    {
        public static async Task CalculateFactorialAsync(long number, Action<long> callback, long item = 1, long resul =1 )
        {
            if (item != number)
                await CalculateFactorialAsync(number, callback, item + 1, resul * item);
            else
                callback(resul);
        }
    }
}
