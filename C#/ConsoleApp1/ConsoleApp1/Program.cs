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
        }
    }
}
