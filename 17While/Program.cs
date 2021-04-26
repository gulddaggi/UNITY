using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17While
{
    class Program
    {
        static void Main(string[] args)
        {
            //for, while 치고 tab두번


            //어떤 함수내에서 bool값이 들어가면 된다.
            //while(참/거짓)
            bool Check = true;
            //조건문(true) -> 실행코드 -> 조건문(false) -> 빠져나옴
            while (Check)
            {
                Console.WriteLine("무한 출력");
                Check = false;
            }

            Check = false;

            //실행코드->조건문
            int Count = 0;
            do
            {
                Count += 1;
                Console.WriteLine(Count);

            } while (Count < 100);
            //일반적인 프로그램에서는 while문은 쓸 때 빠져나올 수 있는 조건을 넣어놓고 실행해줘야 한다.

            Count = 0;
            while (Count < 100)
            {
                Console.WriteLine(Count);
                Count += 1;

            }

        }
    }
}
