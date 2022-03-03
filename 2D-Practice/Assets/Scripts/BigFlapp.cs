using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFlapp : MonoBehaviour
{
    public float jumpForce;
    Rigidbody2D rigid;

    public bool isActive;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.velocity = new Vector2(0, jumpForce);
            isActive = true;
        }

        if (isActive)
        {
            rigid.gravityScale = 1;
        }
    }
}
