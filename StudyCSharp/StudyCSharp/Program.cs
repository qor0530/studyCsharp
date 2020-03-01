using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudyCSharp
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("사용법 : HellWorld.exe <이름>");
                return;
            }
            Console.WriteLine("Hello, {0}!\nNice to Meet You!", args[0]);
        }
    }
}
