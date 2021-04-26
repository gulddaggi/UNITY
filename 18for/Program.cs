using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18for
{
    class Program
    {
        static void Main(string[] args)
        {

            //반복문 3가지 : while, do while, for
            /*for (초기화문; 조건문 ; 증감문)
             {
                실행코드
            
             }
            for문의 장점은 접근성. 하나의 for라는 키워드로 초기화와 조건, 증감문 선언
            한번에 변수를 선언후 초기화하고 조건을 비교하고 변수를 변화시키는 코드를 한 줄에 다 담았다.
            함수 안에서만 사용가능. 함수 밖에서는 사용할 수 없다.


            함수의 인자값은 메모리화 되고 값이 변할 수 있어야 하는데 
            while문은 반환하거나 저장하는 기능을 내포하는 구문이 아니다.
            void Func(while(true))
            {

            } 불가능

            */

            //i++ : 변수 하나와 연산자만 있으면 실행되는 연산자를 단항 연산자라고 한다.
            // 정수형일 때 ++을 하게 되면 1증가하고 --를 하게 되면 1감소하게 된다.
            //초기화문 -> 조건문 -> 실행코드 -> 증감문 반복
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            int y = 0;
            for (; y < 100; y++)
            {
                Console.WriteLine(y);
            }

            //이러면 while 문
            for(;true;)
            {
                Console.WriteLine(100);
            }

        }
    }
}
