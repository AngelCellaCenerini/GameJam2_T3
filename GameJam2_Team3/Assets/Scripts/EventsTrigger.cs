using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsTrigger : MonoBehaviour
{
    // Variables
    public GameObject key;
    public GameObject testCube;


    // Update is called once per frame
    void Update()
    {
        // TEMPORARY - PICK UP KEY
        if (Input.GetKeyDown(KeyCode.Space))
        {
            key.SetActive(false);
        }

        // Check Trigger
        if (!key.activeSelf)
        {
            testCube.transform.position = new Vector3(2.58f, 0.47f, -2.64f);
        }
        
    }
}
