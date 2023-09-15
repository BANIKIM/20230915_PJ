using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Head : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //GetKeyDown 눌렀을때 한번만
        //GetKeyUp 키를 땟을 때
        //GetKey 눌렀을때 계속
        if (Input.GetKey(KeyCode.RightArrow))//키를 눌렀을때
        {
            gameObject.transform.Rotate(Vector3.up * 1f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(Vector3.down * 1f);

        }
    }
}
