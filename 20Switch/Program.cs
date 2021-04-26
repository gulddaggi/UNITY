using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Switch
{
    class Program
    {
        static int Left()
        {
            return 100;
        }

        static void Main(string[] args)
        {
            int Left = 100;
            int Right = 10;
            if (Left == 50)
            {

            }

            int SwitchTest = 0;
            int Test1 = 50;
            
           // ==연산만 가능 
            switch (SwitchTest)
            {
                //case Test1: // 변수는 안된다.
                //오로지 상수와만 비교할 수 있다.
                case 0:
                case 1:
                    Console.WriteLine("SwitchTest는 0또는 1 입니다.");
                    break;
                case 100:
                    Console.WriteLine("SwitchTest는 100 입니다.");
                    break;

                default://else의 역할을 한다.
                    Console.WriteLine("모든 조건이 맞지 않습니다.");
                    break;
            }

            switch (Left > Right)
            {
                case true:
                    Console.WriteLine("SwitchTest는 true입니다.");
                    break;
                case false:
                    Console.WriteLine("SwitchTest는 false 니다.");
                    break;
               
                default:
                    break;
            }

        }
    }
}
