using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loling : MonoBehaviour
{
    public Transform Boby;

    // Update is called once per frame
    void Update()
    {//RotateAround ������ �Ǵ� ������ �������� ������ �켭 ������ �������� ���鶧 ���� �� ����.
        transform.RotateAround(Boby.position , Vector3.up, 1f);
    }
}
