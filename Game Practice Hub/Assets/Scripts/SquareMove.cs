using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMove : MonoBehaviour
{
    public AudioClip ouch;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - Vector3.left, 1);   

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position -= Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position -= Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position -= Vector3.back;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(ouch, transform.position);
    }
}
