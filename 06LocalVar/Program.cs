using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    //클래스 안에 있는 변수는 맴버변수
    int Att;
    int HP;

    void Fight()
    {
        /* 선언되는 순간 지역변수는 메모리화 되고 함수가 끝나면 사라진다.
        지역변수 규칙 1 : 함수 내부에서만 사용가능
        */
        int Damage = 0;
        Console.WriteLine("플레이어가 싸운다.");
    }
}//게임에서 사용하기 위한 설계


namespace _06LocalVar
{
    class Program
    {
        //시작용 함수
        static void Main(string[] args)
        {
            //함수 안에 있는 변수는 지역변수
            int ATT = 0;
            ATT = 50;
            //객채화, 매우 중요한 작업
            Player NewPlayer1 = new Player();
            //Player의 설계대로 플레이어를 만드는데 그 이름을 NewPlayer라고 한다.
            Player NewPlayer2 = new Player();
            //Console.WriteLine("지역변수를 공부해 봅시다.");
        }
    }
}
