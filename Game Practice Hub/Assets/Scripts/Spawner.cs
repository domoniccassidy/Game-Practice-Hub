using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Transform player;
    public ArenaPlayer playerScript;
    private List<string> names = new List<string>() { "John", "Derek", "Barry", "Timothy", "Napoleon", "Simon the Sorcerer" };

    private void FixedUpdate()
    {
        if (Time.time % 4 == 1)
        {
            GameObject newEnemy = Instantiate(enemy);
            newEnemy.GetComponent<Enemy>().Player = player;
            newEnemy.GetComponent<Enemy>().damage = 10;
            newEnemy.GetComponent<Enemy>().playerScript = this.playerScript;

            newEnemy.GetComponent<Rigidbody>().freezeRotation = true ;

            newEnemy.name = "Noob Pig " + names[Random.Range(0, names.Count - 1)];
            newEnemy.transform.position = new Vector3(Random.Range(-20, 20), newEnemy.transform.position.y, Random.Range(-25, 18));
        }
    }
}
