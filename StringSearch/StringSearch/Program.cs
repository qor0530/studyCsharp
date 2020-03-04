﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            // IndexOf()         현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾습니다.
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good")); // 문자열로 0번째니깐 0출력
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf("o")); // 문자로 2번째에 있으니깐 1출력 

            // LastIndexOf()     현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 뒤에서부터 찾습니다.
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good")); // 
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

            // StartsWith()      현재 문자열이 지정된 문자열로 시작되는지를 평가합니다.
            WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            // EndsWith()        현재 문자열이 지정된 문자열로 끝나는지를 평가합니다.
            WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            // Contains()        현재 문자열이 지정된 문자열을 포함하는지를 평가합니다.
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            // Replace()    현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환합니다.
            WriteLine("Replaced 'Morning' with 'Evening' : {0}", greeting.Replace("Morning", "Evening"));
        }
    }
}
