using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct MyVector3 //Right가 기본적으로 이런 형식으로 있다.
{
    static Vector3 m_Right = new Vector3(1.0f, 0.0f, 0.0f);
   public static Vector3 Right
    {
        get {
            return m_Right;

        }
    }
}


public class NewBehaviourScript : MonoBehaviour
{
   

    void Start()
    {
        Transform MyTrans = GetComponent<Transform>();
    }

    void Update()
    {
        transform.position += MyVector3.Right * Time.deltaTime;
    }
}
