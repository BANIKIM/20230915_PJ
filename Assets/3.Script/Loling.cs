using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loling : MonoBehaviour
{
    public Transform Boby;

    // Update is called once per frame
    void Update()
    {//RotateAround 기준이 되는 포지션 주위에서 돌린다 뱀서 고서같은 아이템을 만들때 좋을 것 같다.
        transform.RotateAround(Boby.position , Vector3.up, 1f);
    }
}
