using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19If
{
    class Program
    {
        static void Main(string[] args)
        {
            int Test = 100;
            //조건문
            if (Test == 100)
            {
                Console.WriteLine("Test는 100 입니다.");
            }

            //컨트롤 rr을 누르면 참조되는 변수까지 모두 변경 가능하다.
            int ElseifTest = 10;
            if (ElseifTest == 100)
            {
                Console.WriteLine("ElseifTest는 100 입니다.");
            }
            else if (ElseifTest == 10)
            {
                Console.WriteLine("ElseifTest는 10 입니다.");
            }//위에 조건과 연계되어 위조건이 false일 때 아래조건으로 들어온다.

            int ElseTest = 5;
            if (ElseTest == 100)
            {
                Console.WriteLine("ElseTest는 100 입니다.");
            }
            else if (ElseTest == 5)
            {
                Console.WriteLine("ElseTest는 5 입니다.");
            }
            else
            {
                Console.WriteLine("연계된 모든 조건이 거짓이었습니다.");
            }


        }

    }
}
