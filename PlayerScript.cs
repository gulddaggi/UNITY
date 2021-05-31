using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*class Test
{
    int Number;

    public void Func()
    {
        Number = 1000;
    }
}*/


//파일명과 동일한 클래스가 하나라도 있고 MonoBehaviour를 상속받아야 스크립트로서 GameObject에 넣어주는 것이 가능하다.
public class PlayerScript : MonoBehaviour
{
    //static void Main(string[] _Arg)를 숨겨놨다.
    //특별한 이름으로 함수를 만들었을 때 적절한 시점에 실행해준다.

    PlayerScript()
    {
        UnityEngine.Debug.Log("생성자");

    }


    void Awake()
    {
        UnityEngine.Debug.Log("생성함수");
    }


    void Start() //시점함수라 한다.
    {
       // Test NewTest = null;
       // NewTest.Func();
        //System.Console.WriteLine("하하하");

       // for (int i = 0; i < 100; i++)
       // {
       //     UnityEngine.Debug.Log("하하하");

       // }
        //정적함수, static함수로 맴버변수나 이너클래스를 통한 기능은 아니다.
        UnityEngine.Debug.Log("시작함수");


        Transform MyTrans = GetComponent<Transform>();

       //방어코드를 쳐줘야 한다.
       if (null == MyTrans)
        {
            Debug.Log("트랜스폼이 없어요");
            return;
        }

      
       //벡터 xyz
       // MyTrans.position = new Vector3(2, 0, 0);

        SpriteRenderer SR = GetComponent<SpriteRenderer>();

        if (null == SR)
        {
            Debug.Log("스프라이트 랜더러가 없어요");
            return;

        }

        Status STATUS = GetComponent<Status>();
        if (null == STATUS)
        {

            Debug.Log("스테이터스가 없어요");
            return;
        }

        Debug.Log("현재 공격력 스테이터스" + STATUS.AT);
        STATUS.AT = 5000;
        Debug.Log("변경된 공격력 스테이터스" + STATUS.AT);


        //색상 rgba(0 ~ 0.1)
        // SR.color = new Color(0.0f, 0.0f, 0.0f, 0.5f);

        //SR.flipX = true;


    }
    //this : 현재 플레이어 스크립트 그 자체의 레퍼런스이다




    void Update()
    {
        //GetComponent<SpriteRenderer>()을 미리 만들어놨다.

        //Debug.Log("업데이트"); 게임이 실행해줄 수 있는 프레임이 최대한도로 Update해준다.

        //0, 0, 0
        //+1, 0, 0
        //=1, 0, 0 벡터의 덧셈

        /*
         1, 0, 0 * 2
         = 1*2, 0*2, 0*2
        = 2, 0, 0 *2
         = 4, 0, 0
         벡터와 float하나의 곱셈

        안좋은 컴퓨터 : 1초에 1번 실행한다.
        다른 컴퓨터 : 1초에 2번 실행한다.
        그래서 컴퓨터에서 진짜 초당 시간을 알아올 수 있다. 
        컴퓨터에서 100까지를 무조건 1초 단위로 샐수 있다고 가정

        1           2
   0.5            50 /100 =            0.5
   0.5  100         100 /100 = 1        1
                    150 /100 =          1.5
        200         200 / 200 = 2       2

              1           2                             스피드
   0.5            50 - 0 /100 =                   0.5 * 50 =            25
   0.5  100-0         100-50 /100 =     1         0.5 * 50 = 50         25
                    150-100 /100 =                0.5 * 50 =            75
        200-100         200-150 / 200 = 1         0.5 * 50 = 100        100
        //이게 델타타임


        */
        //단위에도 중요하다.
        transform.position += new Vector3(1.0F, 0.0F, 0.0F) * Time.deltaTime;
    }
}
