using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        enum DialogResult { YES = 10, NO, CANCEL, CONFIRM = 50, OK };
        static void Main(string[] args)
        {
            //boxing_unboxing

            int a = 123;
            object b = (object)a;
            int c = (int)b;

            Console.WriteLine(a);
            Console.WriteLine(b);   // a에 담긴 값을 박싱해서 힙에 저장
            Console.WriteLine(c);   // b에 담긴 값을 언박싱해서 스택에 저장

            double x = 3.1414213;
            object y = x;           // x에 담긴 값을 박싱해서 힙에 저장
            double z = (double)y;   // y에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //IntegralConversion (형식 변환)

            sbyte A = 127;
            Console.WriteLine(A);

            int B = (int)A;
            Console.WriteLine(B);

            int X = 128;
            Console.WriteLine(X);

            sbyte Y = (sbyte)X;     // 오버플로우 발생 
            Console.WriteLine(Y);

            //FloatConversion

            float fa = 69.6875f;
            Console.WriteLine(fa);

            double fb = (double)fa;
            Console.WriteLine(fb);

            Console.WriteLine("69.6875 == fb", 69.6875 == fb);

            float fx = 0.1f;
            Console.WriteLine("fx : {0}", fx);

            double fy = (double)x;
            Console.WriteLine("fy : {0}", fy);

            Console.WriteLine("0.1 == fy : {0}", 0.1 == fy);

            //Constant

            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483647;

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);

            //Enum
            //Main 밖에 enum 선언함

            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);

            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);

            //var (지역 변수로만 사용 가능)

            var var_a = 20;
            Console.WriteLine("Type: {0}, value: {1}", var_a.GetType(), var_a);

            var var_b = 3.1414213;
            Console.WriteLine("Type: {0}, value: {1}", var_b.GetType(), var_b);

            var var_c = "Hello, World!";
            Console.WriteLine("Type: {0}, value: {1}", var_c.GetType(), var_c);

            var var_d = new int[] { 10, 20, 30 };
            Console.WriteLine("Type: {0}, value: ", var_d.GetType());

        }
    }
}
