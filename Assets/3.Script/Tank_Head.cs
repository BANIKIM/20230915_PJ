using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Head : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //GetKeyDown �������� �ѹ���
        //GetKeyUp Ű�� ���� ��
        //GetKey �������� ���
        if (Input.GetKey(KeyCode.RightArrow))//Ű�� ��������
        {
            gameObject.transform.Rotate(Vector3.up * 1f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(Vector3.down * 1f);

        }
    }
}
