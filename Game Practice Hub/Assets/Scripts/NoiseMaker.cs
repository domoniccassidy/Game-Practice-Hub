using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class NoiseMaker : MonoBehaviour
{
    public Transform squareLocation;
    public List<AudioMixerSnapshot> snaps;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,squareLocation.position) < 5)
        {
            snaps[1].TransitionTo(1f);
        }
        if (Vector3.Distance(transform.position, squareLocation.position) > 5)
        {
            snaps[0].TransitionTo(1f);
        }
    }
}
