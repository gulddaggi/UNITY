using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum DMGTYPE
{
    PYDMG,
    FIREDMG,
    ICEDMG
}

class Player
{
    

     int AttDef = 5;
     int FireDef = 5;
     int IceDef = 5;
    int Hp = 100;
    public Player()
    {

    }

    public Player(int _Hp)
    {
        Hp = _Hp;
    }


    static void Func(int _Value)
    {

    }

    static void Func(int _Value, int _Value2)
    {

    }

    //함수오버로딩 : 함수 자료형까지 이름에 포함하여 서로 구별 가능
    //멤버함수, static, 생성자 등 거의 모든 함수에 적용가능
    public void Damage(int _Damage) //Damageint로 인식
    {

    }

    public void Damage(float _Damage, int _Type) //Damagefloatint로 인식
    {

    }


    public void Damage(int _Damage, DMGTYPE _Type)
    {
        switch (_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;
            default:
                break;
        }

        Damage(_Damage);
    
    }

}


namespace _29OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player(1000);
            NewPlayer.Damage(100, DMGTYPE.FIREDMG);
 


        }
    }
}
