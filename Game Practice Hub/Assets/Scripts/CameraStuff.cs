using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStuff : MonoBehaviour
{
    public GameObject car;
    public float distance = 5f;
    public float height = 2f;
    public float dampening = .5f;
    
    // Update is called once per frame

  

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, car.transform.position + car.transform.TransformDirection( new Vector3(0,height,-distance)),dampening* Time.deltaTime);
        transform.LookAt(car.transform);
    }
}
