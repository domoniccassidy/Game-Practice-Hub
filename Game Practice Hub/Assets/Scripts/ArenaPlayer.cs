using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaPlayer : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private Vector3 rotationSpeed;
    private float horizontalInput;
    private float verticalInput;


    // Update is called once per frame
    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position +=  (transform.forward   *  movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= (transform.forward * movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-rotationSpeed);
        }

    }
    
}
