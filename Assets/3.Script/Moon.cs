using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform earth;



    // Update is called once per frame
    void Update()
    {
        //RotateAround 누구를 기준으로 돌수 있다.
        //Time.deltaTime 프레임간의 사이 시간
        transform.RotateAround(earth.position, Vector3.up, -1.5f * Time.deltaTime);
    }
}
