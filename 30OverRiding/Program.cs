using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected string Name = "NONE";
    protected int AT = 10;
    // protected int ItemAT = 10; 필요없는 것도 가지게 되므로 적합하지 않다.
    protected int HP = 100;
    
    /*public static virtual void Test()
    {
        this가 없어서 virtual 안됨. 추후설명
    }
    */

    
    //이 문법의 핵심은 자식에서 나와 같은 이름의 함수나 프로퍼티를 재구현했다면 자식 형태의 그것을 호출한다.
    public virtual int GetAT()
    {
        Console.WriteLine("FIGHTUNIT의 GATAT");
        return AT;

    }
    //부모가 protected면 자식도 protected : 접근제한 지정자 일치
    /*프로퍼티는 virtual 가능
     public virtual int DMGAT
    {
        get
        {
            return AT;
        }
    }
     
     
     */

    //목적 1. 상속의 개념(코드 재활용성)을 지키기 위해서

    public void Damage(FightUnit _OtherFightUnit)
    {
        int AT = _OtherFightUnit.GetAT();
        //각자 플레이어의 것 : _OtherFightUnit.AT;
        Console.WriteLine(_OtherFightUnit.Name + "에게" + AT + "만큼의 데미지를 입었습니다.");
        HP -= AT;

    }

    //생성자는 오버라이딩 할 수 없다.

}

class Player : FightUnit
{
    int ItemAt = 5;

    
    //자식 클래스에 맞게 함수를 재구현하는 것이 오버라이딩이며, 다형성(동적바인딩)의 핵심 문법중 하나이다.
    public override int GetAT() //나는 부모의 GetAt를 재구현했다.
    {
        Console.WriteLine("플레이어의 GATAT");
        return AT + ItemAt;
    }
    public Player(string _Name)
    {
        Name = _Name;
    }
}

class Monster: FightUnit
{
    int MonsterLv = 2;

    public override int GetAT()
    {
        Console.WriteLine("Monster의 GATAT");
        return AT + MonsterLv;

    }

    public Monster(string _Name /*int _MonsterStartLv*/)
    {
        Name = _Name;
    }
}


namespace _30OverRiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player("플레이어");
            Monster NewMonster = new Monster("몬스터");
            // FightUnit NewFight = new FightUnit();


            //NewPlayer.GetAT();
            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
           
        }
    }
}
