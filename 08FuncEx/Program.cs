using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    /*접근제한 지정자를 입력하지 않으면 
      디폴트로 private
      일반적이기 때문
     */
    private int AT = 10;
    private int HP = 100;
    private int LV = 1;


    //리턴값은 객체가 자신의 상태를 외부에 알려주는 용도로 사용
    //return하는 순간 함수가 끝남
    public int GetLv()
    {
        LV = 100;
        return LV;

    }
    public void LVUP()
    {
        HP = 100;
        AT = 100;
    }

    public void SetHP(int _HP)
    {
        //HP에 대한 체크 가능, 핵심은 디버깅 가능
        HP = _HP;
    }
    /* 함수는 선언과 내용으로 나뉜다.
     */

    // void[리턴값] Func[이름 혹은 식별자] ()[인자값]
    //함수란 보통 클래스 외부와의 소통을 위해 작성
    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }


    //리턴값은 자신이 리턴해주려는 자료형과 동일한 자료형이어야 한다.
    public int DamageToHPReturn(int _Dmg)
    {
        HP = HP - _Dmg;
        return HP;
    }

    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }
}



namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.SetHP(100);
            NewPlayer.LVUP();
            NewPlayer.Damage1(10);
            NewPlayer.Damage1(10);
            NewPlayer.Damage2(10, 20);
            //외부의 값을 받아 객체가 내부의 상태를 변화
            Console.WriteLine(NewPlayer.GetLv());

            Console.WriteLine(NewPlayer.DamageToHPReturn(50));
        }
    }
}
