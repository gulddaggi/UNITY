using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    void Update()
    {
        //this�� �����Ѵٴ� ���� ������ �ȵȴ�.
        this.transform.position += MyVector3.Right * Time.deltaTime;

    }
}
