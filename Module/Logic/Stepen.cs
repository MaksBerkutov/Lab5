using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Module.Logic
{
    class Stepen
    {
        public static async Task StepenAsync(long number,long stepen, Action<long> callback, long counter = 0,long res= 0 )
        {
            if (counter == 0) await StepenAsync(number,stepen,callback,1,number);
            else if(counter != stepen) await StepenAsync(number,stepen, callback,counter+1,res*number);
            else callback(res);
        }
    }
}
