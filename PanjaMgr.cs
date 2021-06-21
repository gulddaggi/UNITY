using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanjaMgr : MonoBehaviour
{
    //순서 : 리터럴 초기화(null) -> 엔진 초기화(pixel.png) -> 함수 대입 PanjaSprite(내가 대입해준 값)
   // 2d 이미지를 대표하는 유니티에서 제공하는 클래스이다. 그리고 이를 엔진수준에서 쉽게 세팅하는 법을 지원해준다.
    [SerializeField]
    Sprite PanjaSprite = null;

    //일정 시간마다 판자가 만들어진다. 변수가 존재해야 한다.
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
        //0.0보다는 작지만 가까운 값이다. 이유 : 델타타임은 절대 정확할 수 없다.
        //이전 프레임에서 0.1초 지났다.
        //CreateTime -= Time.deltaTime;
        //빈 게임오브젝트 만드는법.

        if (true)
        {
            GameObject NewPanja = new GameObject("Panja");

           Vector3 CreatePos  = this.transform.position;
           NewPanja.transform.localScale = new Vector3(UnityEngine.Random.Range(3.0f, 10.0f), 1.0f, 1.0f);


            CreatePos.z = 0.0f;
            CreatePos.y = UnityEngine.Random.Range(CreateRandomRangeYStart, CreateRandomRangeYEnd);

            //this.gameObject.AddComponent<SpriteRenderer>();
            NewPanja.transform.position = CreatePos;
            //AddComponent<클래스명>
            SpriteRenderer NewSp = NewPanja.AddComponent<SpriteRenderer>();
            //뭔가 스프라이트를 넣어줘야 화면에 나올 것이다.
            NewSp.sprite = PanjaSprite;
            CreateTime = CreateTimeInter;

        }
    }
}
