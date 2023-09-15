using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Move : MonoBehaviour
{
    public float X_sleep=0 ;
    
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(X_sleep, 0);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position -= new Vector3(X_sleep, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position -= new Vector3(0, 0, 0.1f);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(0, 0, 0.1f);
        }
    }
}
