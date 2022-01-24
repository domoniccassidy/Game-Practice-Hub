using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlayer : MonoBehaviour
{
    [SerializeField] Transform checkGroundTransform;
    [SerializeField] private LayerMask playerMask;
    bool shouldPlayerJump = false;
    float horiInput;
    Rigidbody rigidComponent;
   

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.W) )
        {
            shouldPlayerJump = true;

        }
        horiInput = Input.GetAxis("Horizontal");    
        
    }
    void FixedUpdate()
    {
        rigidComponent = GetComponent<Rigidbody>();
        rigidComponent.velocity = new Vector3(horiInput * 2f, rigidComponent.velocity.y, 0);

        if (Physics.OverlapSphere(checkGroundTransform.position,0.07f,playerMask).Length == 0)
        {
            return;
        }
        if (shouldPlayerJump)
        {
            rigidComponent.AddForce(Vector3.up * 8, ForceMode.VelocityChange);
            shouldPlayerJump = false;
        }
    
    }
    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.layer == 8)
        {
            Destroy(gameObject);
        }
    }


}
