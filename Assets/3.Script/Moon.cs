using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform earth;



    // Update is called once per frame
    void Update()
    {
        //RotateAround ������ �������� ���� �ִ�.
        //Time.deltaTime �����Ӱ��� ���� �ð�
        transform.RotateAround(earth.position, Vector3.up, -1.5f * Time.deltaTime);
    }
}
