using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Module.Logic
{
    class Syntax
    {
        public static async Task SyntaAnalizeCallBackAsync(string str,Action<int,int,int,int> callback)
        {
            await Task.Run(() =>
            {
                int Glas = 0;
                int Soglas = 0;
                int Digit = 0;
                int Space = 0;
                str = str.ToLower();
                foreach (var i in str)
                    switch (i)
                    {
                        case 'a':
                        case 'e':
                        case 'o':
                        case 'i':
                        case 'u':
                            Glas++;
                            break;
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                        case '0':
                            Digit++;
                            break;
                        case ' ':
                            Space++;
                            break;
                        default:
                            Soglas++;
                            break;


                    }
                callback(Glas, Soglas, Digit, Space);
            });
          
        }
    }
}
