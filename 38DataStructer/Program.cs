using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*자료 구조를 직접 만들어 보는 건 게임프로그래머의 언어와 같은 기초소양이다.
  자료구조는 컴퓨터 과학에서 효율적인 접근 및 수정을 가능케 하는 자료의 조직, 관리, 저장을 의미한다.
  더 정확히 말해, 자료 구조는 데이터 값의 모임, 또 데이터 간의 관계, 그리고 데이터에 적용할 수 있는 함수나 명령을 의미한다.
  총알이 1000발이 발사된다. 어떻게 관리할 것인가?
  NPC가 500명이 있다. 그중에서 '피오나'라는 이름의 NPC가 있는데 어떻게 찾을 것인가?
 
 
 
 */

class MyDataStruct<T>
{
    // 넣는다.탐색한다.확장한다.

    public void Push(T _Data)
    {
        //if (/*이 자료가 들어왔을 때 내 사이즈를 오버하면*/)
       // {
        //    MDS.Ex(/*적절한 수*/); 늘린다.
      //  }

        //여러가지 예외처리할 것이 있다.
    }
    public int Find(T _Data)
    {
        return 100;
    }

    public void Ex(int _Size)
    {

    }

}

namespace _38DataStructer
{
    class Program
    {
        static void Main(string[] args)
        {
            //자료구조이다.
            int[] Arr = new int[10];
            Arr[0] = 0;
            Arr[1] = 1;

            int[] Arr2 = Arr;
            Arr = new int[15];
            /*자료구조에는 보통 컨테이너라는 용어를 사용하는데
              시퀸스 컨테이너 : 자료를 넣어주면 순서대로 쌓인다.  List(C#)  vector(C#에서는 없으며 C/C++에 있다.)  SortedList는 연관이다.
              연관 컨테이너 : 자료간 연관이 존재하고 그에따라 정렬한다. (ex_크기순으로 숫자배열 : 규칙에 의해서 자료의 순서를 바꾼다.) Dictionary(해쉬맵)  map(C++)
              어뎁터 컨테이너 : 시퀸스거나 연관인데 한번더 변형이 가해진다.  stack   queue
              로 분류된다.
              자료구조라는 건 int 10 = 0 1 2 3 4 5 6 7 8 9
              자료구조는 다음의 구조나 인터페이스를 지원한다. : 넣는다.     탐색한다.     확장한다.  
             
              데이터의 메모리 구조는 
              배열
              노드형
              으로 나뉜다.
             
             */

            MyDataStruct<int> MDS = new MyDataStruct<int>();

            //100을 넣는다.
            MDS.Push(100);

            //50을 찾는다.
            MDS.Find(50);

            MDS.Ex(50000);
            //확장은 사실 없다. 대부분 자동으로 이뤄진다.
        }
    }
}
