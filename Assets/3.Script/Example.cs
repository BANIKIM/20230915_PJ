using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //������ ������
        //gameObject.transform.position += new Vector3(0.01f,0,0);
        Quaternion q = new Quaternion();
        q.eulerAngles= new Vector3(0.01f, 0, 0);//Quaternion����� ����3�� ������ �̷��� ������ �ʿ��ϴ�.

        gameObject.transform.Rotate(Vector3.up*0.01f);
       
    }

}
