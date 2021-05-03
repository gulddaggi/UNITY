using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    // public:외부까지  protected:자식까지 private:나까지(디폴트)

   protected int AT = 10;
    protected int HP = 100;
    public void Damage(/*FightUnit this,*/FightUnit _OtherUnit)
    {
        //FightUnit이지만 이안에서 플레이어의 기능을 쓰고 싶다.
        //Player OtherPlayer = _OtherUnit; -> 다운캐스팅, 최대한 지양(플레이어를 실수로 몬스터로 변경하게 된다.)

        this.HP -= _OtherUnit.AT;

    }


}



class Player : FightUnit //내려준다 상속시킨다라고 말한다. C#에서 클래스상속이란 오직 하나만 가능
{
    int Lv = 1;
    
    void Heal()
    {
        HP = 100;

    }

}

class Monster : FightUnit
{
    int Exp = 10;
}



namespace _23Inheritance
{
    /*상속이란 코드 재활용성을 향상시키기 위해서 (똑같은 코드 2번 치기 싫어서) 사용한다.
      어떤 계열이 있는가를 파악해야 함.
      방법은 공통되는 기능을 하는 맴버변수와 맴버함수를 걷어낸다.
      새로운 클래스에 그 모든 맴버변수와 함수를 넣는다. 상속시킨다.
    
    */
    class Program
    {
        static void Main(string[] args)
        {
            /*int Value = 500;
              string StrValue = Value;
              변환이란 작업을 거치치 않으면
              이런 일을 발생할 수 없다.
              이는 메모리 구조를 따라간다.(형태가 전혀 다름)
             */


            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();
            //플레이어의 부분을 모두 다 포기하겠다. 이를 업캐스팅이라 한다.
            //자식이 부모형이 되는 것 그럼으로써 자식의 능력은 버린다.
            FightUnit FU = NewPlayer;
            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
            
        }
    }
}
