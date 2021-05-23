using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DicTest
{
    private Dictionary<string, int> NewDic = new Dictionary<string, int>();

    public void Print(string _Name)
    {
        if(false == NewDic.ContainsKey(_Name))
        {
            return;
        }

        Console.WriteLine(NewDic[_Name]);
    }
    
    public void Add(string _Name, int Value)
    {
        if (true == NewDic.ContainsKey(_Name))
        {
            return;
        }

        NewDic.Add(_Name, Value);

    }

}


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //연관 복합
            //string 키, int 벨류(데이터)
            /*Dictionary<string, int> NewDic = new Dictionary<string, int>();

            if (false == NewDic.ContainsKey("일이에요"))
            {
                NewDic.Add("일이에요", 1);

            }
            if (false == NewDic.ContainsKey("이에요"))
            {
                NewDic.Add("이에요", 2);

            }
            NewDic.Add("뭘까요?", 877978);
            NewDic.Add("와와 재밌다.", 2548);
            //NewDic.Add("와와 재밌다.", 4812); 같은 키를 두번 넣어주는 것은 불가능하다.
            //딕셔너리는 같은 키를 넣어줄 일이 있다면 사용하지 않는다.

            NewDic.Remove("와와 재밌다.");

            //인덱서 혹은 연산자 겹지정이라고 한다.
            //딕셔너리는 찾는다는 작업에 특화되어있다.
            Console.WriteLine(NewDic["일이에요"]);
            Console.WriteLine(NewDic["이에요"]);

            string Key = "당연히 없는 값 테스트용";

            if (true == NewDic.ContainsKey("와와 재밌다."))
            {
                Console.WriteLine(NewDic["와와 재밌다."]);
            }*/

            DicTest NewTest = new DicTest();
            NewTest.Add("하하하", 1);
            NewTest.Add("하하하", 1);
            NewTest.Add("하하하1", 21);
            NewTest.Add("키입니다", 9999);

            NewTest.Print("키입니다");
            NewTest.Print("하하하1");


        }
    }
}
