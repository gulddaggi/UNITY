using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{

    //객체가 생기면 만들어지게 되는 맴버변수
    private int HP = 100;

    /*public void Damage(int _Dmg)
    {
        //C#은 대체 어떻게 이 hp가 플레이어 2의 hp라는걸 알 수 있을까?
        HP -= _Dmg;
        this.HP -= _Dmg;
    }*/
    //맴버함수의 호출이란 어차피 넣을 걸 대신 넣어준 것.
    public void Heal(/*Player _this*/ int _Heal)
    {
        //맴버함수에서 맴버변수를 쓴다면 눈에 보이지는 않지만 앞에 this.이 생략된 것이다.
        //this.HP라는 것을 잊으면 안된다.
        HP += _Heal;
    }

    

    
    public static void Damage(Player _this, int _Dmg)
    {
        _this.HP -= _Dmg;
    }

    //정적 맴버변수만을 정적 맴버함수에서 사용할 수 있다.
    private static int StTest = 100;
   public static void PVP(Player _Left, Player _Right)
    {
        StTest = 50;
        //객체에 영향을 받지 않는 것이 정적 맴버함수 정적 맴버변수
       //HP = 1000; 못씀
       //static 맴버함수는 객체를 만들지 않고도 사용할 수 있으므로
       // 자신이라는 개념이 없는 함수이다.
    }


}




namespace _16This
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            NewPlayer2.Heal(100);
            Player.Damage(NewPlayer1, 100);


            Player.PVP(NewPlayer1, NewPlayer2);

        }
    }
}
