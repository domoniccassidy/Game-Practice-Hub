using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MovementSpeed;
    public int damage;
    public Transform Player;
    public ArenaPlayer playerScript;
    // Update is called once per frame
    void Update()
    {
        
        Vector3 dirToPlayer = (Player.position - transform.position).normalized;
        transform.position += dirToPlayer * MovementSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "TankContainer")
        {
            playerScript.Damage(damage);
        }
    }


}
