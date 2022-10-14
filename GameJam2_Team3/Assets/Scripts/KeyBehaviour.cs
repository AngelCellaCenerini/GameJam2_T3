using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    // External References
    private void OnMouseDown()
    {
        // Register Mouse Input
        Debug.Log("clicked!");
        // Collect Object
        gameObject.SetActive(false);

    }

}
