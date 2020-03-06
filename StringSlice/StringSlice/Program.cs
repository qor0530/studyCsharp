using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace StringSlice
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning";

            WriteLine(greeting.Substring(0, 5)); //good
            WriteLine(greeting.Substring(5)); //morning
            WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);

            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);

            //StringFormatBasic

            string fmt = "{0,-20}{1,-15}{2,30};";

            WriteLine(fmt, "publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "C# 7.0 Programming");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
    }
}
