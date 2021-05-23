using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace System
{
    namespace Collections
    {
        namespace Generic
        {
            struct MyTest<Tkey, TValue>
            {

            }
        }
    }
}



class GTest<T>
{
    T Data;
}



namespace DataStructEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> NewDic;

            List<Dictionary<string, int>> NewTest;

            Dictionary<string, int> DicTest = new Dictionary<string, int>();
            List<int> ListTest = new List<int>();
            LinkedList<int> LinkedListTest = new LinkedList<int>();

            ListTest.Add(1);
            ListTest.Add(2);
            ListTest.Add(3);
            ListTest.Add(4);
            ListTest.Add(5);

            LinkedListTest.AddLast(1);
            LinkedListTest.AddLast(2);
            LinkedListTest.AddLast(3);
            LinkedListTest.AddLast(4);
            LinkedListTest.AddLast(5);
            //foreach는 자동적으로 반복하는 문장으로서 in을 통해서 각 배열이든 딕셔너리든 리스트든
            //내부의 자료를 그래도 순회할 수 있게 처리해준다.
            //var은 그때의 가장 적합자료형으로 처리된다.
            //in은 자료구조에서 빼온다라고만 이해해도 된다.
            //그대신 루프에 대한 제한을 하기가 어렵다.




            foreach (var item in ListTest)
            {
                if (3 == item)
                {
                    break;
                }
                
                
                Console.WriteLine(item);
            }

            foreach (var item in LinkedListTest)
            {
                Console.WriteLine(item);
            }

            DicTest.Add("일", 1);
            DicTest.Add("이", 2);
            DicTest.Add("삼", 3);
            DicTest.Add("사", 4);
            DicTest.Add("오", 5);

            System.Collections.Generic.MyTest<int, int> Test;

            //var은 그 시점에서 가장 알맞은 자료형이 되어 준다.
            int Number = 100;
            var AA = Number;


            foreach (KeyValuePair<string, int> item in DicTest)
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}
