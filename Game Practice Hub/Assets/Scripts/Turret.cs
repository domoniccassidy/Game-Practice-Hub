using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        float turretPos = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, turretPos));
    }
}
