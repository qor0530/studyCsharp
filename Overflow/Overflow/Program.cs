using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Overflow
            uint a = uint.MaxValue; // 1111 1111인 상태가 됨

            Console.WriteLine(a); 

            a = a + 1;              // 1111 1111 에서 1 더하니 1 0000 0000 이 되는데 8비트까지만 저장

            Console.WriteLine(a);   //그래서 출력하면 0000 0000 인 0이 나옴

            //Decimal
            float    float_a = 3.1415_9265_3589_7932_3846_2643_3832_79f;    // 숫자 뒤에 f를 붙이면 float 형식으로 간주

            double   double_b = 3.1415_9265_3589_7932_3846_2643_3832_79;    // 아무것도 없으면 double

            decimal  decimal_c = 3.1415_9265_3589_7932_3846_2643_3832_79m; // m을 붙이면 decimal

            Console.WriteLine(float_a); 
            Console.WriteLine(double_b);
            Console.WriteLine(decimal_c); // float < double < decimal 순으로 훨씬 더 많은 수를 표현가능

            //char

            //char hello = '안녕';       == x
            //char everybody = '여러분'; == x

            char A = '안';
            char B = '녕';
            char C = '하';
            char D = '세';
            char E = '요';                     //문자는 작은 따옴표

            Console.Write(A);
            Console.Write(B);
            Console.Write(C);
            Console.Write(D);
            Console.Write(E);
            Console.WriteLine();
            Console.WriteLine();

            //string

            string Hello = "안녕하세요";
            string Everybody = "여러분";       //문자열은 큰 따옴표

            Console.WriteLine(Hello);
            Console.WriteLine(Everybody);

            //bool

            bool yes = true;
            bool no = false;

            Console.WriteLine(yes);
            Console.WriteLine(no);

            //object

            object num = 123;                                        //int             
            object dec = 3.1415_9265_3589_7932_3846_2643_3832_79m;   //decimal
            object boo = true;                                       //bool
            object str = "안녕하세요";                               //string
            
            Console.WriteLine();
            Console.WriteLine(num);
            Console.WriteLine(dec);
            Console.WriteLine(boo);
            Console.WriteLine(str); // 모든 형식을 다룰 수 있는 데이터 형식
        }
    }
}
