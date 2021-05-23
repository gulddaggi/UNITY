using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







class Player
{
   public enum PLAYERJOB
    {

        //다른곳에 정의될수도 있지만 플레이어의 내부에 넣어줄수도 있다.
        //그 클래스가 자기만 사용할 때 가장 많이 사용한다.
        NOVICE,
        KNIGHT,
        FIGHTER,
        BERSERKER,
        FIREMAGE

    }

    //직업과 관련된 멤버변수도 있어야 함. 
    PLAYERJOB Job = PLAYERJOB.NOVICE;
    void ClassChange()
    {

    }


}



class Inven
{
   private int SelectIndex = 0;
    //자기 클래스 내부에 있지만 이너클래스는 다른 클래스일 뿐이다.
    //일단 private -> get set -> public(남들이 알아야 하는가를 판단하는 과정)

    public void InnerClassTest()
    {
        InvenSlot NewInvenSlot = new InvenSlot();
        NewInvenSlot.Select(this);


    }
    public class InvenSlot
    {
        int Index;
       public void Select(Inven _inven)
        {
            //자신을 가지는 클래스의 멤버변수를 마치 public처럼 사용할 수 있다. 
            _inven.SelectIndex = 100;
            //SelectIndex = 100; 사용불가
        }

    }


    //이럴거면 밖에 있어도 되지만(스타일에 따라) 이름 겹침에서 자유롭다.
    //온전히 하나의 클래스가 자신의 내부에서 모든걸 처리할 수 있게 하려면
    //자신과 밀접히 관련된 자료형들도 자신 내부에 들고 있는 것이 좋다.
    public enum INVENDIR
    {
        ID_LEFT,
        ID_RIGHT,
        ID_UP,
        ID_DOWN,
    }

    //어느 방향으로 움직이는가?
    void SelectMove(/*방향을 의미할만한 인자값 */)
    {

    }

}





class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        Inven NewInven = new Inven();
        Inven.INVENDIR IDER = Inven.INVENDIR.ID_LEFT;
        NewInven.InnerClassTest();
    }
}
