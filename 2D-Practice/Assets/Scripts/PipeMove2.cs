using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove2 : MonoBehaviour
{
    public float pipeSpeed;
    public BigFlapp bigFlapp;

    // Update is called once per frame
    private void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.RandomRange(-4.37f, 2));
    }
    private void Update()
    {
        if (bigFlapp.isActive)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-pipeSpeed, 0);
        }
    }

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "teleport")
        {
            Debug.Log("teleported!");
            transform.position = new Vector3(12, Random.RandomRange(-4.37f, 2));
        }
    }
}
