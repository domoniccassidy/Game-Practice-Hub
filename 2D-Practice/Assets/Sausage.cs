using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sausage : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 gravity;
    public Vector3 jumpPower;
    Vector3 velocity = new Vector3(0, 0, 0);
    // Update is called once per frame
    void Update()
    {
        velocity -= gravity;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity = jumpPower;
        }
        
        transform.position += velocity * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        
       
    }
}
