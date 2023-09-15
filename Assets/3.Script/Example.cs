using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //앞으로 앞으로
        //gameObject.transform.position += new Vector3(0.01f,0,0);
        Quaternion q = new Quaternion();
        q.eulerAngles= new Vector3(0.01f, 0, 0);//Quaternion사용을 벡터3로 쓰려면 이러한 과정이 필요하다.

        gameObject.transform.Rotate(Vector3.up*0.01f);
       
    }

}
