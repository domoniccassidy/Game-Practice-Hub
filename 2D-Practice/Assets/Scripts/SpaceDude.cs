using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDude : MonoBehaviour
{
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("hi");
            transform.position = Vector2.Lerp(transform.position, transform.position + Vector3.right, 5);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("hi");
            transform.position = Vector2.Lerp(transform.position, transform.position + Vector3.left, 5);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bul = Instantiate(bullet,GetComponentInChildren<Transform>().position,Quaternion.identity);
            
        }
    }
}
