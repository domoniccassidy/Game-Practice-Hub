using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienScript : MonoBehaviour
{
    public int pointsWorth;
    bool right = true;
    bool down = false;
    float wait = 0;
    int count = 0;

    private void Update()
    {
        wait += Time.deltaTime;
        if (wait >= 1.5)
        {
            wait = 0;
            if (down)
            {
                transform.position += Vector3.down;
                down = false;
            }
            else
            {
                
                if (right)
                {
                    transform.position += Vector3.right;
                    count += 1;
                }
                else if (!right)
                {
                    transform.position -= Vector3.right;
                    count -= 1;
                }
                if (count == 3)
                {
                    right = false;
                    down = true;
                }
                else if (count == -2)
                {
                    right = true;
                    down = true;

                }
            }

        }

    }
  
}
