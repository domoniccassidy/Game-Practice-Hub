using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MovementSpeed;
    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        
        Vector3 dirToPlayer = (Player.position - transform.position).normalized;
        transform.position += dirToPlayer * MovementSpeed * Time.deltaTime;
    }
}
