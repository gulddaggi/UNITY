using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




class Node<T>
{

    //몇개가 되건 상관없다. 보통 노드는 게임 맵에서 많이 사용한다.
    public Node<T> Next;
    public Node<T> Prev;
}

class MyLinkList<T>
{
    public Node<T> First;
    public Node<T> Last;
}



namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> LList = new LinkedList<int>();
            //시퀸스 배열형 : List
            //시퀸스 노드형 : LinkedList

            LList.AddFirst(10);
            //LList.AddLast(10); 초반에는 뭘로 하든 의미가 없다.
            LList.AddLast(90);
            LList.AddFirst(50);
            LList.AddLast(70);
            //LList.Remove(10);
            //LList.RemoveFirst();
            //LList.RemoveFirst();

            LinkedListNode<int> Cur = LList.First;
            Cur = Cur.Next;

            LList.AddAfter(Cur, 999);
            
            //다 지워라 LList.Clear();

            for (
            LinkedListNode<int> StartNode = LList.First;
                 null != StartNode;
                 StartNode = StartNode.Next)
            {
                Console.WriteLine(StartNode.Value);
            }
            //중간시작은 안된다.
            for (
           LinkedListNode<int> StartNode = LList.Last;
                null != StartNode;
                StartNode = StartNode.Previous)
            {
                Console.WriteLine(StartNode.Value);
            }


        }
    }
}
