using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    public Text scoreText;
    public int shotSpeed;
    float bulletLife = 3;
    // Update is called once per frame
    void Update()
    {
        bulletLife -= Time.deltaTime;
        if (bulletLife <= 0)
        {
            Destroy(gameObject);
        }
        
        transform.position += Vector3.up * shotSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject);
        int currentScore = int.Parse(scoreText.text);
        scoreText.text = (currentScore + other.GetComponent<AlienScript>().pointsWorth).ToString();
        other.gameObject.AddComponent<DIE>();
        Destroy(other);
        Destroy(gameObject);
    }
}
