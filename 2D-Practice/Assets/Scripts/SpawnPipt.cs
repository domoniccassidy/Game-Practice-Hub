using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipt : MonoBehaviour
{
    public GameObject pipeTotal;
    public float pipeSpeed;
    public BigFlapp bigFlapp;
    List<GameObject> pipes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pipes.Count < 2)
        {
           GameObject pt=  Instantiate(pipeTotal);
            pt.AddComponent<PipeMove2>();
            pt.GetComponent<PipeMove2>().pipeSpeed = pipeSpeed;

            pt.GetComponent<PipeMove2>().bigFlapp = bigFlapp;


            pipes.Add(pt);
        }
    }
}
