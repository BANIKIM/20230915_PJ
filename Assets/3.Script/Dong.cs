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
        //RotateAround 누구를 기준으로 돌수 있다.
        //Time.deltaTime 프레임간의 사이 시간
        transform.RotateAround(Body.position, Vector3.up, Speed * Time.deltaTime);
    }
}
