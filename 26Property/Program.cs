using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    //보통 어떤 맴버변수가 타겟이다.
    int AT = 10;

    public int HP;
    static int m_StaticValue = 100;
   public static int StaticValue
    {
        get
        {
            return m_StaticValue;

        }

        set
        {
            m_StaticValue = value;

        }

    }

    //자료형을 선언했다면 이는 int와 관련된 함수라고 명시하는 것.
    public int ProAT
    {
        //프로퍼티의 GET 함수는 무조건 int를 리턴한다고 본다.

        get
        {
            return AT;
        }
        //무조건 int하나가 들어온다고 생각한다. 그런 외부 값들을 프로퍼티에서는 value라고 기호로 정의해 놨다. 
        set
        {
            AT = value;

        }
    }

    //컨트롤 스페이스 = 자동완성
    public int GetAT()
    {
        if (999 < AT)
        {
            Console.WriteLine("최대 수정치를 넘겼습니다.");
            while (true)
            {
                Console.ReadKey();
            }
        }

        return AT;
    }

    public void SetAT(int _Value)
    {
        if(999< _Value)
        {
            Console.WriteLine("최대 수정치를 넘겼습니다.");
            while (true)
            {
                Console.ReadKey();
            }
        }
        AT = _Value;

    }

}



namespace _26Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            Player.StaticValue = 200;
            NewPlayer.HP = 80;

            NewPlayer.ProAT = 100;
            int PlayerAT = NewPlayer.ProAT;

            //NewPlayer.SetAT(99999);
        }
    }
}
