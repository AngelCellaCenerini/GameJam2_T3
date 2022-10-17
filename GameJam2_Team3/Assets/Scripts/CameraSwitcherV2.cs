using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcherV2 : MonoBehaviour
{
    // Variables
    public GameObject[] Cameras;

    int currentCam;

    public Camera CurrentCamera => Cameras[currentCam].GetComponent<Camera>();

    // Start is called before the first frame update
    void Start()
    {
        currentCam = 0;
        setCam(currentCam);
    }

    // Update is called once per frame
    void Update()
    {
        // Check Input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            toggleCam();
        }
    }

    // Switches Cameras in array between tru and false state
    public void setCam(int idx)
    {
        for (int i = 0; i < Cameras.Length; i++)
        {
            //Grabs next Camera and labels as true
            if (i == idx)
            {
                Cameras[i].SetActive(true);
            }
            else
            //Sets all other cameras to false
            {
                Cameras[i].SetActive(false);
            }
        }
    }

    //Triggers camera switch in array
    public void toggleCam()
    {
        currentCam++;

        //Resets camera array number back to 0 at the end of the array
        if (currentCam > Cameras.Length - 1)
            currentCam = 0;
        setCam(currentCam);
    }
}
