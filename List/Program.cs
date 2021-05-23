using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Item
{

}

class MyList<T>
{
    int[] Arr = new int[0];
    int Capa = 0;
    int Count = 0;

    public void Add(T _Add)
    {
        if (Count + 1 >= Capa)
        {
            //확장
        }
    }
}



namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<int> NewInt = new MyList<int>();
            NewInt.Add(100);


            //넣는 함수     찾는 함수   지우는 함수  확장



            //배열형 시퀸스
            List<int> NewList = new List<int>();
            //매번 관리 대상이 바뀔 수 있으므로 제네릭 클래스여야 한다.
            //자료 : 넣어준 int

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((NewList.Count + 1).ToString() + "Add");
                Console.WriteLine("Capacity : " + NewList.Capacity); // 배열의 크기
                Console.WriteLine("Count : " + NewList.Count); //자료의 크기
                NewList.Add(i);
            }

            Console.WriteLine("");
            Console.WriteLine("Contains");



            //내부에 자료가 있는지 없는지 여부를 알려준다. 탐색에는 유리하지 않은 자료구조라고 본다.
            //하지만 인덱스로 표현할 수 있다면 탐색에 가장 유리한 자료구조다.
            if (NewList.Contains(8))
            {
                Console.WriteLine("내부에 8이 있습니다.");
            }
            //인덱서 혹은 연산자 겹지정이라고 부르는데, 

            if (NewList.Contains(999999))
            {
                Console.WriteLine("내부에 999999이 있습니다.");
            }
            else
            {
                Console.WriteLine("내부에 999999이 없습니다.");

            }
            Console.WriteLine(NewList[5]);

            NewList.Remove(10); // 10이 있다면 지운다.

            NewList.RemoveAt(1); //첫번째를 지운다.
            //NewList.RemoveAll(); 다른 리스트 혹은 배열을 넣어줬을때 비교해서 중복되면 지운다.
            NewList.RemoveRange(0, 4);// 0번째부터 4개 지워라.
            for (int i = 0; i < NewList.Count; i++)
            {
                Console.Write(NewList[i]);
            }
            Console.WriteLine("");

            int[] Arr = NewList.ToArray();
            //ArgumentOutOfRangeException -> OutOfRange
            //자료의 개수로 판단하지 배열의 크기는 중요하지 않다.
            // Console.WriteLine(NewList[16]); 터짐

            NewList.Clear();
        }
    }
}
