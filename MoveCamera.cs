using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    void Update()
    {
        //this가 존재한다는 것을 잊으면 안된다.
        this.transform.position += MyVector3.Right * Time.deltaTime;

    }
}
