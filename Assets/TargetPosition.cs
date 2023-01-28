using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPosition : MonoBehaviour
{
    public Transform target;

    public void LeftPosition()
    {
        target.localPosition = new Vector3(4.4f,3f,-45f);

    }

    public void RightPosition()
    { 
        target.localPosition = new Vector3(-9.2f, 3f, -45f);

    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            LeftPosition();
        }
        if (Input.GetKey(KeyCode.D))
        {
            RightPosition();
        }
    }
}
