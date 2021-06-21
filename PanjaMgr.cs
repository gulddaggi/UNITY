using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanjaMgr : MonoBehaviour
{
    //���� : ���ͷ� �ʱ�ȭ(null) -> ���� �ʱ�ȭ(pixel.png) -> �Լ� ���� PanjaSprite(���� �������� ��)
   // 2d �̹����� ��ǥ�ϴ� ����Ƽ���� �����ϴ� Ŭ�����̴�. �׸��� �̸� �������ؿ��� ���� �����ϴ� ���� �������ش�.
    [SerializeField]
    Sprite PanjaSprite = null;

    //���� �ð����� ���ڰ� ���������. ������ �����ؾ� �Ѵ�.
    [SerializeField]
    private float CreateTime = 1.0f;

    [SerializeField]
    private float CreateTimeInter = 1.0f;
    [SerializeField]
    private float CreateRandomRangeYStart = -2.0f;
    [SerializeField]
    private float CreateRandomRangeYEnd = -2.0f;
   
    [SerializeField]
    private float CreateRange = 20.0f;
    [SerializeField]
    private float LastCreateX = 0.0f;
    [SerializeField]
    private float LastCreateScaleX = 0.0f;

    void Update()
    {
        //0.0���ٴ� ������ ����� ���̴�. ���� : ��ŸŸ���� ���� ��Ȯ�� �� ����.
        //���� �����ӿ��� 0.1�� ������.
        //CreateTime -= Time.deltaTime;
        //�� ���ӿ�����Ʈ ����¹�.

        if (true)
        {
            GameObject NewPanja = new GameObject("Panja");

           Vector3 CreatePos  = this.transform.position;
           NewPanja.transform.localScale = new Vector3(UnityEngine.Random.Range(3.0f, 10.0f), 1.0f, 1.0f);


            CreatePos.z = 0.0f;
            CreatePos.y = UnityEngine.Random.Range(CreateRandomRangeYStart, CreateRandomRangeYEnd);

            //this.gameObject.AddComponent<SpriteRenderer>();
            NewPanja.transform.position = CreatePos;
            //AddComponent<Ŭ������>
            SpriteRenderer NewSp = NewPanja.AddComponent<SpriteRenderer>();
            //���� ��������Ʈ�� �־���� ȭ�鿡 ���� ���̴�.
            NewSp.sprite = PanjaSprite;
            CreateTime = CreateTimeInter;

        }
    }
}
