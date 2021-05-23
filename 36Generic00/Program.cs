using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//정적 변수와 정적 함수만을 내부에 둘 수 있는 static 클래스
//그래서 생성자를 만들 수 없다.
static class GTest
{
    //제네릭 함수(멤버함수에도 통용된다.) : 자료형을 변수처럼 사용하고 싶을 때.
    //함수의 식별자에 <다양한 자료형을 대표할 이름> : 제네릭.
    public static T ConsolePrint<T>(T _Value)
    {
        Console.WriteLine(_Value);
        return _Value;
    }

    public static T ConsolePrint<T, U>(T _Value1, U _Value2)
    {
        Console.WriteLine(_Value1);
        Console.WriteLine(_Value2);

        return _Value1;
    }

    public static void Test(int _Test)
    {

    }

}

class CashItem
{

}

class GameItem
{

}

//제네릭 클래스
class Inven<T>
{
    T[] ArrInvenItem;
    //GameItem[] ArrInvenItem;
    //CashItem[] ArrInvenItem;

    public void ItemIn(T _Item)
    {

    }

}



class Program
{
    static void Main(string[] args)
    {
        //명시적 호출은 할 수 있다.
        GTest.ConsolePrint<int>(1000); //정수
        GTest.ConsolePrint(1.31123f); //실수
        GTest.ConsolePrint("하하하호호호"); //글자

        GTest.ConsolePrint("하하하호호호", "gggg"); //글자

        //이건 무조건 명시적으로 만들어줘야 한다.
        Inven<GameItem> NewGameItemInven = new Inven<GameItem>();
        Inven<CashItem> NewCashItemInven = new Inven<CashItem>();
        GameItem NewItem = new GameItem();
        CashItem NewCashItem = new CashItem();

        NewGameItemInven.ItemIn(NewItem);
        NewCashItemInven.ItemIn(NewCashItem);


    }
}
