using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Monster
{

    static int MonsterDeathCount;

    public void Death()
    {
        MonsterDeathCount += 1;
    }
}

class Player
{
    /*일반적 맴버변수와 다르게 static을 붙이게 되면
      정적 맴버변수라고 한다.
     일반적인 맴버변수와 다르게 객체화를 하지 않고도 사용할 수 있다.
     그 사용법이 클래스의 이름만으로 사용할 수 있다.
     */
    public static int PlayerCount = 0;
    public int AT = 10;
    public int HP = 100;
    //클래스 내부에서는 사용이 가능하다.
    public void Setting(int _AT, int _HP)
    {
        PlayerCount = 100;
        AT = _AT;
        HP = _HP;
    }

}

class SidePlayer
{
    /*정적맴버변수
     객체에 귀속된것이 아니라
     클래스 자체에 귀속되고
    데이터 영역에 메모리가 올라간다.
     */
    static public int PlayerCount;


    /* static이 붙지 않은 변수를
      맴버변수라고 부르면
     객체 하나하나가 자신의 것을 가진다.
     */
    public int X = 0;
    public int Y = 0;
    public int HP = 0;
    public void Gravity()
    {
        Y -= 200;
    }

}




namespace _13StaticVar
{
    class Program
    {
        static void Main(string[] args)
        {

            /*static 변수는 게임 내에서 하나만 존재하며 
              일반적으로 클래스 내부에서 모든 객체가 공유하고 싶은
              변수를 만들 때 사용한다.
            */
            SidePlayer.PlayerCount = 3;
            SidePlayer NewPlayer11 = new SidePlayer();
            SidePlayer NewPlayer22 = new SidePlayer();
            SidePlayer NewPlayer33 = new SidePlayer();





            //플레이어를 3번 new하면 3개 생긴다. 각각의 HP를 가지고 있다.
            Player NewPlayer1 = new Player();
            Player.PlayerCount = 1;
            Player NewPlayer2 = new Player();
            Player.PlayerCount = 1;
            Player NewPlayer3 = new Player();
            Player.PlayerCount = 1;

            //NewPlayer3.PlayerCount 처럼 객체를 통해서 정적맴버변수를 사용할 수 없다.
            /* 이런식으로 객체화를 전혀 하지 않고 사용할 수 있는 것을
               정적 맴버변수라 부르고
            이는 데이터 영역에 들어가게 된다.

            어떤 클래스가 공유하고 싶은 값
            ex)몬스터 클래스라면 현재 존재하는 모든 몬스터의 수
            객체를 아무리 만들어도
            정적 맴버는 그 객체와의 관련성은 객체 내부에서 사용할 수 있을 뿐
            객체의 개수만큼 만들어지는 것은 아니다.
            즉 모든 객체가 공유하는 하나의 변수가 되어준다.
            */

            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();


            //모든 객체가 값을 공유할 필요가 있는 데이터를 정의하는데 사용한다.
            NewMonster1.Death();
            NewMonster2.Death();
            NewMonster3.Death();


            //멤버변수는 각각 존재.
            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 50);
            NewPlayer3.Setting(100, 500);



            /* 메모리 영역
               코드 : 상수, 클래스 선언 그 차체 함수의 내용 그 자체 수정이 불가능한 요소
               데이터 : 정적맴버변수
               힘 : new 클래스명() 만들어진 클래스 객체들의 본체가 여기있다.
               스택 : 함수의 실행 메모리 영역
             */
        }
    }
}
