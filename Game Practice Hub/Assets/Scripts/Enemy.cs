using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MovementSpeed;
    public int damage;
    public Transform Player;
    public ArenaPlayer playerScript;
    public int knockbackForce;

    bool activated = false;
    Vector3 dirToPlayer = new Vector3(0, 0, 0);
    // Update is called once per frame
    void Update()
    {
        
         dirToPlayer = (Player.position - transform.position).normalized;
        if (activated)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
            transform.position += dirToPlayer * MovementSpeed * Time.deltaTime;
        }
        else
        {
            this.GetComponent<MeshRenderer>().material.color = Color.black;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            playerScript.Knockback(dirToPlayer,knockbackForce);
            playerScript.Damage(damage);
        }
    }

    public void SetActivated(bool activated)
    {
        this.activated = activated;
    }

}
