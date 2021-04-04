using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    //객체지향의 캡슐화, 은닉화를 대표하는 문법 : 접근제한 지정자
    
    //세가지 접근제한 지정자가 존재
    public int HP; //외부에도 공개
    protected int ATT; //자식에게만 공개
    private int DEP; //내부에만 공개
    public void Fight()
    {
        Console.WriteLine("싸운다.");
    }
}



namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // 만들어진 객체의 내용을 사용하기 위해 객체의 이름.을 사용한다.
            // 접근제한 지정자 문법을 사용하지 않아 외부에 공개하지 않음
            NewPlayer.HP = 1000;
            NewPlayer.Fight();
        }
    }
}
