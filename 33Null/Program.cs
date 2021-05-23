using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    private int mAT;
    public int MAT { get { return mAT; } }
    public int AT {
        get { return mAT; }
        set { mAT = value; }
    
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        //가리키는게 없이 비워놓겠다. 참조형의 데이터 구조를 가지는 자료형들(ex 클래스)은
        //
        Player NewPlayer2 = null;

        Console.WriteLine(NewPlayer.AT);
        //System.NullReferenceException 용어가 사용되는데 
        Console.WriteLine(NewPlayer2.AT);
    }
}