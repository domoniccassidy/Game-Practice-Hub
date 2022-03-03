using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject alien1;
    public Transform alienZone;
    void Start()
    {
        for (int i = -2; i < 3; i++)
        {
            Instantiate(alien1, new Vector3(i * 2, 4),Quaternion.identity,alienZone);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
