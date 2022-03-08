using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{


    public float strength;
    public float maxTurn;
    public Rigidbody body;
    private void Start()
    {
        body = GetComponent<Rigidbody>();
    
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            body.AddForce(transform.forward * strength * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            body.AddForce(-transform.forward * strength * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -maxTurn));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, maxTurn));
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Checkpoint")
        {
            Debug.Log("You have passed a checkpoint");
        }
    }
}
