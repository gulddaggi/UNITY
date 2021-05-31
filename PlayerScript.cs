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


//���ϸ�� ������ Ŭ������ �ϳ��� �ְ� MonoBehaviour�� ��ӹ޾ƾ� ��ũ��Ʈ�μ� GameObject�� �־��ִ� ���� �����ϴ�.
public class PlayerScript : MonoBehaviour
{
    //static void Main(string[] _Arg)�� ���ܳ���.
    //Ư���� �̸����� �Լ��� ������� �� ������ ������ �������ش�.

    PlayerScript()
    {
        UnityEngine.Debug.Log("������");

    }


    void Awake()
    {
        UnityEngine.Debug.Log("�����Լ�");
    }


    void Start() //�����Լ��� �Ѵ�.
    {
       // Test NewTest = null;
       // NewTest.Func();
        //System.Console.WriteLine("������");

       // for (int i = 0; i < 100; i++)
       // {
       //     UnityEngine.Debug.Log("������");

       // }
        //�����Լ�, static�Լ��� �ɹ������� �̳�Ŭ������ ���� ����� �ƴϴ�.
        UnityEngine.Debug.Log("�����Լ�");


        Transform MyTrans = GetComponent<Transform>();

       //����ڵ带 ����� �Ѵ�.
       if (null == MyTrans)
        {
            Debug.Log("Ʈ�������� �����");
            return;
        }

      
       //���� xyz
       // MyTrans.position = new Vector3(2, 0, 0);

        SpriteRenderer SR = GetComponent<SpriteRenderer>();

        if (null == SR)
        {
            Debug.Log("��������Ʈ �������� �����");
            return;

        }

        Status STATUS = GetComponent<Status>();
        if (null == STATUS)
        {

            Debug.Log("�������ͽ��� �����");
            return;
        }

        Debug.Log("���� ���ݷ� �������ͽ�" + STATUS.AT);
        STATUS.AT = 5000;
        Debug.Log("����� ���ݷ� �������ͽ�" + STATUS.AT);


        //���� rgba(0 ~ 0.1)
        // SR.color = new Color(0.0f, 0.0f, 0.0f, 0.5f);

        //SR.flipX = true;


    }
    //this : ���� �÷��̾� ��ũ��Ʈ �� ��ü�� ���۷����̴�




    void Update()
    {
        //GetComponent<SpriteRenderer>()�� �̸� ��������.

        //Debug.Log("������Ʈ"); ������ �������� �� �ִ� �������� �ִ��ѵ��� Update���ش�.

        //0, 0, 0
        //+1, 0, 0
        //=1, 0, 0 ������ ����

        /*
         1, 0, 0 * 2
         = 1*2, 0*2, 0*2
        = 2, 0, 0 *2
         = 4, 0, 0
         ���Ϳ� float�ϳ��� ����

        ������ ��ǻ�� : 1�ʿ� 1�� �����Ѵ�.
        �ٸ� ��ǻ�� : 1�ʿ� 2�� �����Ѵ�.
        �׷��� ��ǻ�Ϳ��� ��¥ �ʴ� �ð��� �˾ƿ� �� �ִ�. 
        ��ǻ�Ϳ��� 100������ ������ 1�� ������ ���� �ִٰ� ����

        1           2
   0.5            50 /100 =            0.5
   0.5  100         100 /100 = 1        1
                    150 /100 =          1.5
        200         200 / 200 = 2       2

              1           2                             ���ǵ�
   0.5            50 - 0 /100 =                   0.5 * 50 =            25
   0.5  100-0         100-50 /100 =     1         0.5 * 50 = 50         25
                    150-100 /100 =                0.5 * 50 =            75
        200-100         200-150 / 200 = 1         0.5 * 50 = 100        100
        //�̰� ��ŸŸ��


        */
        //�������� �߿��ϴ�.
        transform.position += new Vector3(1.0F, 0.0F, 0.0F) * Time.deltaTime;
    }
}
