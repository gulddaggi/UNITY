using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    //public �϶��� ��������� �״�� ����Ƽ ȭ�鿡 �巯����.
    //����Ƽ�� ó���ϴ� ������� ���� ����ϴµ� SOLID ����å�ӿ�Ģ�� �����ϴ� ���̴�.
    //attribute��� ������ �����ϴµ� �̴� �������� ó�������� �������ִ� �����̴�.
    
    [SerializeField]
    private int m_HP = 100;

    [SerializeField]
    private int m_AT = 20;

    public int HP
    {
        get
        {
            return m_HP;
        }
        set
        {
            m_HP = value;
        }
    }

    public int AT
    {
        get
        {
            return m_AT;
        }
        set
        {
            m_AT = value;
        }
    }

}
