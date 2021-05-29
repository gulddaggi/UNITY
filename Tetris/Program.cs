using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//오류 났던 이유 : 1. 랜덤이 안됬는데 함수를 만들어놓고 사용을 안했다.
//2. 줄이 맘대로 지워졌는데 괄호{}처리를 잘못했다.
//3. 블럭이 알아서 내려오는 거에 대한 예외처리는 강의에 안나와있어서 아직 못했고 input()에 있던 y += 1을 지워서 오류를 해결했다.


namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            TETRISSCREEN NewSC = new TETRISSCREEN(10, 15, true);
            AccScreen NewASC = new AccScreen(NewSC);
            Block NewBlock = new Block(NewSC, NewASC);



            while (true)
            {
                for (int i = 0; i < 100000000; ++i)
                {
                    int a = 0;
                }



                Console.Clear();
                NewSC.Render();
                //누군가 쌓인다 자체에대한 정보를 가지고 있어야 한다.
                NewSC.Clear();
                NewASC.Render();
                NewASC.DestroyCheck();
                NewBlock.Move();


            }

            /*string Str = "";
            for (int i = 0; i < 10; i++)
            {
                if (true)
                {
                    Str += "■";
                }
                

            }

            Console.WriteLine(Str);

            //아예 판을 한번에 그리는 방법
            for (int y = 0; y < 15; ++y)
            {

                for (int i = 0; i < 10; ++i)
                {
                    if (y == 0 || y == 14)
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write("□");

                    }

                }

                Console.WriteLine("");
            }
            */
            //덮어씌워서 그리기
            //Console.CursorLeft = 6;
            // Console.CursorTop = 6;
            // Console.Write("▣"); 이후 반복문


            /* while (true)
                 {
                 Console.ReadKey();
                  }
                 Console.CursorLeft = 5;
                 Console.CursorTop = 5;

                 Console.CursorLeft = 10;
             */
        }
                
    }
    

}
