using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    public int Hp = 100;
    public int AT = 10;

    public bool IsDeath()
    {
        Console.WriteLine("이 플레이어가 죽었는지 살았는지 체크하는 함수입니다.");
        Console.WriteLine("이 플레이어의 HP가 0보다 작다면 죽습니다.");
        return Hp <= 0;
    }

    public void TestFunc(Player _Player)
    {
        TestFuncPart1(_Player);
    }

    public void TestFuncPart1(Player _Player)
    {
        TestFuncPart2(_Player);

    }

    public void TestFuncPart2(Player _Player)
    {
        //null은 값에 직접적으로 접근을 하면 터진다.
        _Player.AT = 20;
    }
}

class Program
{

    static int Number = 100;
    //배열도 가능
    static void ArrTest(int[] _ArrTest)
    {
        _ArrTest[0] = 9999;
    }

    static void ClassTest(Player _Test)
    {
        _Test.AT = 10000;
    }

    static void AtTest(Player _Test)
    {
        Console.WriteLine("공격력을 테스트 해볼까요?");
        Console.WriteLine("그냥 해보는 겁니다.");

        _Test.AT = 10000;
    }

    static void Main(string[] args)
    {
        //Player NewPlayer 는 할 수 있는 일이 어떤 녀석을 가리키는 일밖에 하지 못한다.
        //다른 녀석을 가리킬 수 있다.

        //new Player()는 어떻게 될까?
        Player NewPlayer = new Player();
        NewPlayer.AT = 50;

        NewPlayer.TestFunc(null);

        Player NewPlayer2 = NewPlayer;

        NewPlayer2.AT = 999;

        //힙에있는 것이 이 함수에 들어갔다 나왔다는 개념
        ClassTest(NewPlayer);


        //배열을 만들자 마자 초기화 : 한번에 모든 값을 다 넣어줘야 한다.
        int[] ArrNumber = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        NewPlayer = new Player();
        ArrTest(ArrNumber);
        //배열은 레퍼런스 형이다.

        // AtTest(null);

        Player NewPlayer3 = null;
        NewPlayer3.IsDeath();

    }
}
