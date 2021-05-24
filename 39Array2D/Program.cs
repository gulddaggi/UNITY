using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39Array2D
{
    class Program
    {
        //List<int>를 자료형으로 사용하는 List
        static List<List<int>> NewArr;
        static List<int>[] ArrList;
        static int[][] Arr2Dint;

        static void Main(string[] args)
        {
            //List를 담을 수 있는 리스트를 만든 것
            NewArr = new List<List<int>>();
            //개수가 시작부터 정해져있다는 점이 차이이다.
            ArrList = new List<int>[10];

            Arr2Dint = new int[10][];
            // Arr2DInt[0]번째에 배열이 들어갈수는 있는데 크기가 정해져 있지 않다.
            //int의 배열을 담을 수 있는 배열

            //이런식의 차이가 있다.
            Arr2Dint[0] = new int[100];
            Arr2Dint[1] = new int[20];

        }
    }
}
