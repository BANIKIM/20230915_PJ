using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotating : MonoBehaviour
{
    public float Sleep = 0;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, Sleep);
    }
}
