using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ArenaPlayer : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private Vector3 rotationSpeed;
    public HealthBarScript healthBar;
   
    public int maxHealth;
    private int currentHealth;
    private float horizontalInput;
    private float verticalInput;
    private bool knockback;
    private float knockbackStart;

    // Update is called once per frame
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void Update()
    {
        if (knockback) 
        {
            knockbackStart -= Time.deltaTime;
            //transform.position += -transform.forward * movementSpeed * 3 * Time.deltaTime;
            //transform.position += transform.up * movementSpeed * 3 * Time.deltaTime;


            if (knockbackStart <= 0)
            {
                knockback = false;
            }
            
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position +=  (transform.forward   *  movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= (transform.forward * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-rotationSpeed);
        }
        if (Input.GetKey(KeyCode.R))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if (Input.GetKey(KeyCode.G))
        {
            GetComponent<MeshRenderer>().material.color = Color.green;

        }

        if (Input.GetKey(KeyCode.B))
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;

        }


    }
    public void Damage(int damage)
    {
  
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth == 0)
        {
            Die();
        }
    }
    public void Knockback(Vector3 e, int knockbackForce)
    {
        knockback = true;
        knockbackStart = 0.8f;

        GetComponent<Rigidbody>().AddForce((e + new Vector3(-0.2f,1f)) * knockbackForce);

    }
    private void Die()
    {
        Destroy(gameObject);

    }

    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();

        enemy.SetActivated(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Enemy enemy = other.GetComponentInParent<Enemy>();

        enemy.SetActivated(false);
    }

}
