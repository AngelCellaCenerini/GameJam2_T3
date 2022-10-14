using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    // External References
    public GameObject key;

    private void OnMouseDown()
    {
       if (!key.activeSelf)
       {
            // Register Mouse Input
            Debug.Log("clicked!");
            // Open Door
            gameObject.SetActive(false);
        }
    }
}
