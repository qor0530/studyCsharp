using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralTypes
{
    class IntegralTypes
    {
        static void Main(string[] args)
        {
            sbyte a = -10;  // 부호가 있는 정수
            byte b = 40;    // 부호없는 정수                                    -   byte, sbyte = 1 byte

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000; //부호없는 정수
            ushort d = 60000; //부호가 있는 정수                                -   short, ushort = 2 byte

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_0000; //부호가 있는 정수, 0이 7개
            uint f = 3_0000_0000; //부호없는 정수, 0이 8개                      -   int, uint = 4 byte

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000; //부호가 있는 정수, 0이 11개
            ulong h = 200_0000_0000_0000_0000; //부호가 없는 정수, 0이 18개     -   long, ulong = 8 byte

            Console.WriteLine($"g={g}, h={h}\n");
        

            byte Re_a = 240;         // 10진수 리터럴
            Console.WriteLine($"Re_a={Re_a}");

            byte Re_b = 0b1111_0000; // 2진수 리터럴, 0b는 접두사
            Console.WriteLine($"Re_b={Re_b}");

            byte Re_c = 0xF0;        // 16진수 리터럴, 0x는 접두사
            Console.WriteLine($"Re_c={Re_c}");

            uint Re_d = 0x1234_abcd; // 16진수 리터럴, 0x는 접두사
            Console.WriteLine($"Re_d={Re_d}\n");
            
            //* 부호 없는 정수를 있는 정수로 변환 할때 *
            
            byte unsigned_a = 255;               //255 = 1111 1111 
            sbyte signed_b = (sbyte)unsigned_a;  //sbyte 형식으로 변환시켜서 signed_b에 값을 넣음 
            Console.WriteLine(unsigned_a);       //↳ 1111 1111 에 -1 한 다음 1->0 0->1 로 변환하면 0000 0001이 됨 ??? 그럼 이상한데..
            Console.WriteLine(signed_b);         //이 부분 다시 공부 
        }
    }
}
