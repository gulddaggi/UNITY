using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            if (0 == i % 2)
            {
                //만약 이 문장을 만나면 반복문의 증감문으로 바로 이동한다.
                //while 문에도 통한다.
                continue;
            }

           

            Console.WriteLine(i);
        }

        for (int i = 0; i < 100; i++)
        {
            if (i == 50)
            {
                break;
            }
            Console.WriteLine();
        }
        //continue와 break는 가장 가까운 반복문의 for(증감문) while(조건문)으로 나간다.
    }
}
