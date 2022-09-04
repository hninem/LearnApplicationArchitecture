using System;
using System.Collections.Generic;
using System.Linq;
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
    }        
}