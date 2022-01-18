using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Vector3 OrbitSpeed = new Vector3(0,0,0);
    private float orginialY = 0;

    private void Start()
    {
        orginialY = OrbitSpeed.y;
    }
    void Update()
    {

        transform.Rotate(OrbitSpeed);
        if (Input.GetKey(KeyCode.UpArrow) && OrbitSpeed.y < (orginialY*4))
        {
            var newSpeed = OrbitSpeed.y + orginialY* 0.004f;
            OrbitSpeed = new Vector3(0, newSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && OrbitSpeed.y > orginialY)
        {
            var newSpeed = OrbitSpeed.y - orginialY * 0.004f;
            OrbitSpeed = new Vector3(0, newSpeed, 0);
        }
    }
}
