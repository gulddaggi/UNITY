using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//사용자 정의 자료형인데
interface QuestUnit
{
    //int A = 0;와 같이 멤버변수 선언 불가
    //함수의 형태만 물려 줄 수 있는 문법이다. 무조건 public, 내용 정의 불가
    void Talk(QuestUnit _OtherUnit);
    void Event(QuestUnit _OtherUnit);
}
class FightUnit
{
    int AT;
    int DMG;

    public void Damage()
    {

    }
}
//인터페이스는 함수구현을 강제할 수 있다. 상속보다 포함의 개념이라 하는 경우가 많다.
//
class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void Event(QuestUnit _OtherUnit)
    {

    }

}

class NPC : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void Event(QuestUnit _OtherUnit)
    {

    }
}

class Monster : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void Event(QuestUnit _OtherUnit)
    {

    }
}


class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NPC NewNPC = new NPC();
        //QuestUnit QuestUnit = new QuestUnit(); 불가능, 형태가 없기 때문에
        QuestUnit NewQuestUnit = NewNPC;
        NewQuestUnit.Talk(NewPlayer);

        //업캐스팅이 가능하다.
        NewPlayer.Talk(NewNPC);
        NewNPC.Talk(NewPlayer);
    }
}
