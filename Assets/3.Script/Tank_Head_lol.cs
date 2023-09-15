using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Head_lol : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKey(KeyCode.Q))
        {//Rotate È¸Àü
            gameObject.transform.Rotate(Vector3.up,0.1f);
        }
        else if(Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Rotate(Vector3.up, -0.1f);
        }
    }
}
