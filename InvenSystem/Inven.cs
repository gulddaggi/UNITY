using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//잘못쓰기도 힘들게 만들어라.
//아이템을 담아두는 인벤토리를 만들고 싶다.
//인벤토리가 만들어질때 최대 몇개를 담을 수 있는지부터 정해야 한다. 
//이때 숫자가 두개 필요한데, x와 y이다. 그럼 담을 수 있는 아이템의 총 개수는 x * y
class Inven
{

    int SelectIndex = 0;
    Item[] ArrItem;
    int ItemX;

    //인벤토리를 new하려면 int X와 Y를 넣어주는 방법밖에 없게 만들었다.
    public Inven(int _X, int _Y)
    {
        //초보프로그래머가 가장 주의해야 할 것. 방어코드는 선택이 아니다.
        //방어코드란? switch문의 디폴트 혹은 프로그램이 터지거나 오작동하지 않게
        //들어오는 값들을 체크해서 문제가 없게 만드는 코드 함수나 이런곳에서 인자값을 받을 때
        //반드시 이것을 검사하고 사용한다.

        if (1 > _X)
        {
            _X = 1;
        }

        if (1 > _Y)
        {
            _Y = 1;
        }
        ItemX = _X;
        ArrItem = new Item[(_X * _Y)];


    }


    //객체의 교류 : 인벤은 아이템이 필요하다.
    public void ItemIn(Item _Item)
    {
        int Index = 0;

        //index만 몇번이 될지 잘 정하면 된다.

        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (null == ArrItem[i])
            {
                Index = i;
                break;

            }
        }

        ArrItem[Index] = _Item;
    }
    
    public void ItemIn(Item _Item, int _Order)
    {
        if (null != ArrItem[_Order])
        {
            return;
        }

        

        ArrItem[_Order] = _Item;
    }

    //셀렉트 인덱스가 화면 바깥으로 넘어갔는가?
    public bool OverCheck(int _SelcetIndex)
    {
        return false;
    }
    //인자값으로 어느 방향으로 움직였는지 주는것이 좋다.
    public void SelectMove()
    {

    }
    public void SelectMoveLeft()
    {
        int CheckIndex = SelectIndex;
        CheckIndex -= 1;
        if(true == OverCheck(SelectIndex))
        {
            return;
        }
        SelectIndex -= 1;

    }
    public void SelectMoveRight()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += 1;
        if (true == OverCheck(SelectIndex))
        {
            return;
        }
        SelectIndex += 1;
    }

    public void SelectMoveUp()
    {
        int CheckIndex = SelectIndex;
        CheckIndex -= ItemX;
        if (true == OverCheck(SelectIndex))
        {
            return;
        }
        SelectIndex -= ItemX;
    }
    public void SelectMoveDown()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += ItemX;
        if (true == OverCheck(SelectIndex))
        {
            return;
        }
        SelectIndex += ItemX;
    }


    public void Render()
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            
            // 15개의 아이템을 가질 수 있는 인벤. i번째에 아이템이 있는가?
            
            if(0 != i && 0 == i % ItemX)
            {
                Console.WriteLine("");
            }

            if (SelectIndex == i)
            {
                Console.Write("▣");
            }
            else if(null == ArrItem[i])
            {
                Console.Write("□");
            }
            else
            {
                Console.Write("■");
            }
        }
        Console.WriteLine("");
        if (null != ArrItem[SelectIndex])
        {
            Console.WriteLine("현재 선택한 아이템");
            Console.WriteLine("이름 : " + ArrItem[SelectIndex].Name);
            Console.WriteLine("가격 : " + ArrItem[SelectIndex].Gold);
        }
        else
        {
            Console.WriteLine("현재 선택한 아이템");
            Console.WriteLine("비어있음");

        }


    }


}
