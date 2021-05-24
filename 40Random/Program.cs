using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Random
{
    class Program
    {
        //난수의 환상 : 프로그래밍에서 난수란 존재하지 않는다.
        //공식은 외부의 다른 데이터를 끌어들이지 않는다. 변수가 자신이 계산한 데이터를 저장해 놓지도 않는다.

        //난수 알고리즘에서는 시드값이라고 한다. PreValue를 초기화하는 값은 매번 바뀌는 값이어야 한다.
        //그래서 시드값을 정할 때는 시간을 이용하는 경우가 많다.


        static int PreValue = 1;
        static int Func()
        {
            int X = 0;
            X += PreValue;

            //어떤한 계산식에 의해 X가 난수로 변한다.
            return X;
        }
        static void Main(string[] args)
        {
            Random NewRandom = new Random();
            //난수를 뽑아내고 
            //NewRandom.Next();0~42억까지의 난수
            //NewRandom.Next() % 10
            //10 == MaxValue

            while (true)
            {
                //10까지 나온다.
                int Random = NewRandom.Next(0, 10);
                Console.WriteLine(Random);
                Console.ReadKey();
            }

        }
    }
}
