using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlayer : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && GetComponent<Rigidbody>().velocity.y == 0)
        {
            Debug.Log("hi");
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
        }   
    }
}
