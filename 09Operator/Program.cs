using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    int HP = 100;

    void Damege(int _HP)
    {
        HP = HP - 10;
    }

    bool ReturnTrue()
    {
        return true;
    }

    public int Plus(int _Left, int _Right)
    {
        int Result =  _Left + _Right;

        return Result;
    }
}


namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            int Result = 0;
            int Left = 7;
            int Right = 3;

            // = 대입연산자. 값을 변수에 대입 오른쪽부터 실행

            //산술연산자
            Result = NewPlayer.Plus(Left, Right); // 더하기
            Result = Left + Right; // 더하기
            Result = Left - Right; // 빼기
            Result = Left * Right; // 곱하기
            Result = Left / Right; // 나누기
            Result = Left % Right; // 나머지
            Result = Left + Right * 10;
            //산술 연산 수행. 나누기와 나머지에는 0은 안된다.
            //제로디비전이라 하는 오류 발생, 프로그램이 실행도중 터질정도의 오류이므로 주의

            /* 비교연산자는 논리형으로 리턴. bool이라는 형태가 있다.
             bool 참과 거짓이 true와 false로 상수화 됨 
             */

            int Number = -36778921;

            bool BResult = true;
            BResult = false;
            BResult = Left > Right; //Left가 Right보다 큰가?
            BResult = Left < Right; //Left가 Right보다 작은가?
            BResult = Left <= Right; //Left가 Right보다 작거나 같은가?
            BResult = Left >= Right; //Left가 Right보다 크거나 같은가?
            BResult = Left == Right; //Left와 Right가 같은가?
            BResult = Left != Right; //Left와 Right가 다른가?
            // 맞으면 true, 틀리면 false
            // 조건문에서 유용하게 쓰임

            //bool 논리 연산자
            BResult = true && false; //AND
            BResult = true && true;
            BResult = true && true && false;
            BResult = true || false; //OR
            BResult = false || false;
            BResult = true ^ false; //XOR : 양쪽이 다르면 true, 같다면 false
            BResult = true ^ true;
            BResult = false ^ true;
            BResult = false ^ false;
            BResult = !true; // NOT. true면 false, false면 true
            BResult = !(Left > Right);

            //축약 연산자 : 산술 연산자를 축약
            Result = 0;
            Result = Result + 10;
            Result += 10;
            Result -= 10;
            Result /= 10;
            Result *= 10;
        }
    }
}
