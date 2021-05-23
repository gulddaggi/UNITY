using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//맵을 표현할때 굉장히 좋은 형식.
class Room
{
    Room[] OtherRoom = new Room[4];
    //Room Left;
    //Room Right;
    //Room Top;
    //Room Bot;

}



//노드는 단순히 자료구조에서만 사용하는 것은 아니다.
//자료구조라고 치면 자료를 보관해야 하므로

class Node<T>
{
    public T Data;

    //자신 안에 자기자신을 또 가지는 형태로 되어있는 클래스들을 노드라고 할 수 있다.
    //자기자신의 레퍼런스를 가지는 방식으로 표현할 때가 많다.
    //노드의 개수가 제한이 없다. 형태로 외우려고 한다. 한개만 있을 때 단방향 노드
    //두개만 있을 때 양방향 노드
    //트리노드
    public Node<T> Next = null;
    public Node<T> Prev = null;

    public Node(T _Data)
    {
        Data = _Data;
    }
}




class Program
{
    static void Main(string[] args)
    {
        Node<int> Node1 = new Node<int>(10);
        Node<int> Node2 = new Node<int>(999);
        Node<int> Node3 = new Node<int>(578);

        Node1.Next = Node2;
        Node2.Next = Node3;

        Node3.Prev = Node2;
        Node2.Prev = Node1;

        Node<int> RCurNode = Node3;
        Node<int> CurNode = Node1;

        while (null != CurNode)
        {
            Console.WriteLine(CurNode.Data);
            CurNode = CurNode.Next;
        }


        while (null != RCurNode)
        {
            Console.WriteLine(RCurNode.Data);
            RCurNode = RCurNode.Prev;
        }

    }
}
