using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{

    public Vector3 pipeSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.position -= pipeSpeed * Time.deltaTime;
    }
}
