using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankingConsoleApp
{
    static class MyExtensions
    {
        public static int Increase(this int a)
        {
            return a + 1;
        }
        public static int Decrease(this int a)
        {
            return a - 1;
        }       
    }
}