using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform circle;

    void FixedUpdate ()
    {
        transform.position = new Vector3(circle.position.x, circle.position.y, transform.position.z);
        
    }

   
   

    
}
