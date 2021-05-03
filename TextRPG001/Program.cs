using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//코드 재활용성이 떨어진다는 표현을 사용하게 되는데, 이를 향상시키기 위한 문법이 상속이다.

class FightUnit
{
    protected string Name = "None";
    protected int AT = 10;
    protected int HP = 50;
    protected int m_MAXHP = 100;

    public int MAXHP
    {
        set
        {
            m_MAXHP = value;
        }

        get
        {
            return m_MAXHP;
        }
    }

    public bool IsDeath()
    {
        // bool boolDeath = HP <= 0; 연산자도 함수에 가깝다.
        return HP <= 0;

    }

    public void StatusRender()
    {

        Console.WriteLine(Name + "의 능력치--------------------------------- ");
        Console.WriteLine("공격력 : " + AT.ToString());
        Console.WriteLine("체력 : " + HP.ToString() + "/" + m_MAXHP.ToString());
        Console.WriteLine("--------------------------------- ");
        Console.WriteLine("");
    }

    public void Damage(FightUnit _OtherUnit)
    {
        Console.Write(Name);
        Console.Write("가");
        Console.Write(_OtherUnit.AT);
        Console.WriteLine("의 데미지를 입었습니다.");
        Console.ReadKey();
        HP -= _OtherUnit.AT;
    }


}



class Player : FightUnit
{
    


    public void PrintHP()
    {
        //객체의 맴버변수와 관련된 코드를 2번 이상 친다면 함수로 만들어라.
        Console.WriteLine("");
        Console.Write("현재 플레이어의 HP는");
        Console.Write(HP);
        Console.WriteLine("입니다.");
        Console.ReadKey();

    }

    public void MaxHeal(/*Player this*/)
    {
        //함수는 비대하지 않을수록 좋다.
        //5~10줄 정도의 함수를 많이 만들어서 이를 다시모아서 함수를 만든다.
        if (HP >= m_MAXHP)
        {
            Console.WriteLine("");
            Console.WriteLine("체력이 모두 회복되어있어서 회복할 필요가 없습니다.");
            Console.ReadKey();
        }
        else
        {
            this.HP = m_MAXHP;
            PrintHP();
            return;
        }
        
    }
    public Player()
    {
        Name = "플레이어";

    }




}


class Monster : FightUnit
{
    //인자값을 만들어 줄 수도 있다.
    public Monster(string _Name)
    {
        Name = _Name;

    }


}


//에러나 잘못된 선택에 관한 것도 만든다.
enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    NONESELECT
}
    

namespace TextRPG001
{
 
    class Program
    {
        //시작 : 마을로 갈지 싸움터로 갈지 정함
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 싸움터");
            Console.WriteLine("어디로 가시겠습니까?");

            //return이란 구문은 리턴이 한번이라도 되는순간 함수를 완전히 종료시킨다.
            //그 아래 많은 코드는 사용 불가.
            ConsoleKeyInfo CKI = Console.ReadKey();

            Console.WriteLine("");

            

            switch (CKI.Key)
            {
                case ConsoleKey.NumPad1:
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.NumPad2:
                    Console.WriteLine("싸움터로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }



        }

        
        static STARTSELECT Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에서 무슨일을 하시겠습니까?.");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");
                //초반 프로그래밍 : 객체(클래스)를 선언해야 할 때,
                //맴버변수, 함수의 분기, 함수의 통합과 분리 관리


                //ConsoleKey CK = Console.ReadKey().Key; 로 사용가능
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.NumPad1:
                        //_Player.HP = _Player.MAXHP; 불가능
                        _Player.MaxHeal();
                        break;
                    case ConsoleKey.NumPad2:
                        break;
                    case ConsoleKey.NumPad3:
                        return STARTSELECT.NONESELECT;
                }
            }

        }

        

        static STARTSELECT Battle(Player _Player)
        {
            Monster NewMonster = new Monster("오크");
            
            //객체지향 : 객체를 지향해서 사용한다.
            while (false == NewMonster.IsDeath() && false == _Player.IsDeath())
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster.StatusRender();
                Console.ReadKey();
                NewMonster.Damage(_Player);
                if (false == NewMonster.IsDeath())
                {
                    _Player.Damage(NewMonster);
                }
            }

            Console.WriteLine("싸움이 결판 났습니다.");
            if (true == NewMonster.IsDeath())
            {
                Console.WriteLine("플레이어의 승리입니다.");
            }
            else
            {
                Console.WriteLine("몬스터의 승리입니다.");
            }
            Console.ReadKey();
            return STARTSELECT.SELECTTOWN;



        }

        static void Main(string[] args)
        {
            //객체지향 프로그래밍이란 결국 클래스로 설계하고 객체로 만들어 나가는 것.
            // 객체화 하지 않고도 쓸 수 있는 함수 : static 함수, 정적맴버변수
            /* ConsoleKeyInfo KeyInfo = Console.ReadKey();

             Console.WriteLine(KeyInfo.Key);
            */
            Player NewPlayer = new Player();

            STARTSELECT SelectCheck = STARTSELECT.NONESELECT;
            while (true)
            {
                //함수가 한가지의 용도로만 사용가능한지 자체의 용도를 생각해라

                switch (SelectCheck)
                {
                    case STARTSELECT.NONESELECT:
                        SelectCheck = StartSelect();
                        break;
                    case STARTSELECT.SELECTTOWN:
                        SelectCheck = Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        SelectCheck = Battle(NewPlayer);
                        break;
                    
                }
            }

        }
    }
}
