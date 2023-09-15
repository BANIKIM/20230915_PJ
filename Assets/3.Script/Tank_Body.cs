using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Body : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.UpArrow))
            {
            transform.position += new Vector3(0, 0, 0.1f);
        }
       else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, -0.1f);
        }
    }
}
