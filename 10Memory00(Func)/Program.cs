using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 메모리를 안다는 것은 코드의 동작원리를 아는 것과 같다.

class Player
{
    int HP = 100;
    int AT = 100;

    // 함수의 인자값 int _Dmg는 지역변수이다. 
    // 함수가 끝나면 사라진다.
    public void Damage(int _Dmg)
    {

    }
}




class Program
{
    /*메인 함수
    static을 빼면 함수의 모양을 가지고 있고
    이곳을 시작이라고 잡은 함수
    C#의 규칙 : Main 이라는 이름의 함수에서부터 시작한다.
     */
    static void Main()
    {
        /* 메모리 크기는 지역변수 + a로 계산되는데
           최소한 지역변수를 다 포함할 수 있는 크기만큼을 가져야 한다.
         
         */
        int Value = 0;
        //함수는 메모리화 되지 않는다. 실행하고 사라짐.
        Console.WriteLine("메모리 1차 함수");
        Player NewPlayer = new Player();
        //객체를 만들었다는 것은 메모리를 지불했다는 것
        NewPlayer.Damage(10);
    }
}
