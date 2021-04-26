using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Monster
{
    public int AT = 10;
    public int HP = 100;

    public void ATT(Player _Player)
    {


    }
}

class Player
{
    public int AT = 10;
    public int HP = 100;

     //Monster _Monster 클래스가 객체화된 것을 받았다.
    public void ATT(Monster _Monster)
    {
        _Monster.HP -= AT; //90

    }

    public void TEST(int _Test)
    {

        _Test = 9000;

    }


}

namespace _12Memory02_reference_
{
    class Program
    {
        /* 클래스가 객체화된 것은
           레퍼런스 형이라고 하고
           int, bool과 같은 것은 값형이라고 한다.
          값형과 레퍼런스 형은 메모리의 위치와 사용법이 다르기 때문에
          다르게 동작한다.
          기본자료형을 선언만 하면 값형
          자기가 만든 클래스를 new 클래스명(); 해서 만든것을 그 클래스명에 받으면 레퍼런스 형
         */
        static void Main(string[] args)
        {

            // 레퍼런스 : 힙에 생성된 어떠한 메모리의 위치를 가리키는 값
            Monster NewMonster = new Monster();//new : 힙영역에 생성
            Player NewPlayer = new Player();

            NewMonster.ATT(NewPlayer);
            NewPlayer.ATT(NewMonster);

            /*안에 값을 끌어내고 싶으면 .을 통해 끌어낸다.
              정확한 이해 : 내가 가리키는 위치에 있는 HP를 사용하겠다.
             힙 : new 클래스명() 만들어진 클래스 객체들의 본체
            스택 : 함수의 실행 메모리 영역(그 박스안에 들어있는 지역변수)
             */

            int Value = 100;

            NewPlayer.TEST(Value);
        }
    }
}
