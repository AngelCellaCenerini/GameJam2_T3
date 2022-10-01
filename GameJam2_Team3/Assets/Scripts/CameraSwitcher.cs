using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Variables
    public GameObject cam1;
    public GameObject cam2;

    // Update is called once per frame
    void Update()
    {
        // Check Input
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Check Current Camera
            if (cam1.activeSelf)
            {
                // Manage Cameras
                cam1.SetActive(false);
                cam2.SetActive(true);
            }
            else if (cam2.activeSelf)
            {
                // Manage Cameras
                cam1.SetActive(true);
                cam2.SetActive(false);
            }
        }
    }
}
