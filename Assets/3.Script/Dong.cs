using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dong : MonoBehaviour
{
    public Transform Body;
    public float Speed = 0;


    // Update is called once per frame
    void Update()
    {
        //RotateAround ������ �������� ���� �ִ�.
        //Time.deltaTime �����Ӱ��� ���� �ð�
        transform.RotateAround(Body.position, Vector3.up, Speed * Time.deltaTime);
    }
}
