using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0.1f, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -0.5f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 0.5f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
    }
}
