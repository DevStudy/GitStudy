using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"CallingVersion:{FunHelper.GetCallingVersion()}");
            Console.WriteLine($"Version:{FunHelper.GetVersion()}");
            Console.Read();
        }
    }
}
