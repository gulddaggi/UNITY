using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    int AT;
    int HP;


    public int Test(int _Dmg) // value의 값만 받은 것
    {
        _Dmg = 1000;
        return _Dmg;
    }
}



namespace _11Memory00_Value_
{
    class Program
    {
        static void Main(string[] args)
        {
            //함수의 인자값
            int Value = 0;


            Player NewPlayer = new Player();
            Value = NewPlayer.Test(Value);
            //값형의 처리
            //값과 위치에 대한 이해가 필요.
            Console.WriteLine(Value);


        }
    }
}
