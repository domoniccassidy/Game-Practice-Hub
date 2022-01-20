using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject topDown;
    public GameObject horizontal;
    public GameObject firstPerson;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (firstPerson.activeSelf)
            {
                topDown.SetActive(false);
                horizontal.SetActive(true);
                firstPerson.SetActive(false);
            }
            else if(horizontal.activeSelf)
            {
                topDown.SetActive(true);
                horizontal.SetActive(false);
                firstPerson.SetActive(false);
            }
            else if (topDown.activeSelf)
            {
                topDown.SetActive(false);
                horizontal.SetActive(false);
                firstPerson.SetActive(true);
            }
        }
    }
}
