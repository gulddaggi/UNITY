using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래밍에 있어서 기본기 : 디버깅(일단 중단점) 95%, 문자열 3%, 파일입출력 2%


namespace _25String01
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자
            char Charactor = 'a';
            //string은 동적 기본자료형이다. char의 집합
            string TEST = "aaadflkjjl";
            
            //자료형은 C#에서 만들어 놓은 기본구조체이다.
            int AAA = new int();
            AAA = 100;
            TEST = AAA.ToString();

            //int는 구조체고 내부의 맴버변수나 함수가 존재하며 그것을 통해서 문자열로 변환을 해줄 수 있다.

            string Left = "안녕하세요.";
            string Right = "날씨가 좋네요.";
            string Result = Left + Right + AAA.ToString();
            //string Result = Left - Right - AAA.ToString(); 는 안됨.

            Console.WriteLine(Result);



        }
    }
}
