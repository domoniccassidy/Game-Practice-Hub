using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpaceDude : MonoBehaviour
{
    public GameObject bullet;
    public Text txt;
    public float shotDelay;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = Vector2.Lerp(transform.position, transform.position + Vector3.right, 5);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = Vector2.Lerp(transform.position, transform.position + Vector3.left, 5);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bul = Instantiate(bullet,GetComponentInChildren<Transform>().position + new Vector3(0,0.5f), Quaternion.identity);
            bul.GetComponent<BulletScript>().shotSpeed = 5;
            bul.GetComponent<BulletScript>().scoreText = txt;
        }
    }
}
