using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*****************************************20210715****************************************************/
            int apple;
            apple = 1;

            /*
             *  매직 넘버
             *      변수를 지정해서 값을 넣어야 명확히 어떤 값을 나타내는지 표현 할 수 있음.
             *      상수를 직접적으로 넣을때 매직 넘버(Magic Number)라고 한다. 안좋다. 쓰지말자.
             *      Console.Write(1); X 안좋음
             */
            Console.Write(apple);

            /*
             *  변수명 짓기
             *      명확해야함. 다른 이들이 코드를 보았을 때 이해가 되야함.
             *      예) "총 개수"의 뜻을 가진 변수는 totalCount 라고 정의하는게 좋음.
             *      상수일 경우에는 대문자로 정의한다. 명사가 2개 이상일 경우 언더바를 사용해서 정의한다.
             *      TOTAL_COUNT
             */

            /*const의 의미는 상수*/
            const int TOTAL_COUNT = 10;

            String userName;
            userName = "honggil";

            /* 기본 자료형(Primitive Types) = 원시자료형 
             *  컴퓨터가 이해할 수 있는 가장 자연스러운 형태의 데이터
             *  0과 1로만 표현
             *  2진수, 10진수
            */


            /*****************************************20210716****************************************************/
            //char가 ASCII 코드이기에 묵시적 형변환이 가능하다.
            //flot double 모두 가능하다.
            char char1 = 'a';

            int int1 = char1;
            Console.WriteLine("int1: " + int1);

            long long1 = char1;
            Console.WriteLine("long1: " + long1);


            //명시적 형변환
            //float 에서 int 로 묵시적 형변환이 불가능한 이유는

            long long2 = long.MaxValue;
            int long2ToInt = (int)long2;

            Console.WriteLine("long2: " + long2);
            Console.WriteLine("long2ToInt: " + long2ToInt); // -1

            //소수점이 날아가기에 원 데이터 변형이 일어난다. 그래서 명시적으로 프로그래머가
            //동의(?)를 해줘야 컴파일러가 정상작동이 가능하다.
            float float2 = 3.14159f;
            int float2ToInt = (int)float2;

            Console.WriteLine("float2: " + float2);
            Console.WriteLine("float2ToInt: " + float2ToInt); // 3

            // 결과값은 4294967295이 나온다
            // -1은 int의 경우 32bit 이다. 그러면 1111 1111 1111 1111 1111 1111 1111 1111 
            // 32번째 있는 자리의 1은 -로 인식되기에 -1이다
            // int는 부호가 있는 정수, uint는 부호없는 정수이다.
            // 32번째 있는 자리를 -로 인식하지 않아, 1111 1111 1111 1111 1111 1111 1111 1111을 10진수로 변환하면 4294967295가 나온다.
            int int2 = -1;
            uint int2ToUInt = (uint)int2;

            Console.WriteLine("int2: " + int2);
            Console.WriteLine("int2ToUInt: " + int2ToUInt); // 4294967295


            /*****************************************20210717****************************************************/
            int number1 = 10;
            int number2 = 30;
            int result1 = number1 / number2;
            double result2 = number1 / number2;
            // int / double 일경우 double이 나온다. 컴파일러가 자동으로 double로 처리됨.
            // 일반적으로 업계에서 둘중에 하나를 double로 둔다. 그런데 보통 분모를 double로 많이 한다. 그런데 분자로 해도 상관없다.
            double result3 = (double)number1 / (double)number2;

            int number3 = 15;
            int number4 = 30;
            int result = number3 % number4;

            // 증가/감소 연산자
            // num = num + 1; 보다 ++num; 이 더 빠르게 작동한다. 하드웨어적인 부분과 연관이 있어서 num = num + 1; 보다는 ++num;을 사용!
            int num = 10;
            char ch = 'b'; // 0x62

            ++num; // 11
            ++ch; // 0x63

            // 부동소수점형은 안되나?
            // 3.14 증가시키면?
            // 부동소수점형은 증가/감소 연산자를 사용하지 않음.
            // 정수형(char, int, long)에만 사용;

            int num10 = 3;
            Console.WriteLine(++num10); 
        }
    }

}
