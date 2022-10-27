using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearKey : MonoBehaviour
{
    public GameObject key;
    public GameObject cabinet;

    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (cabinet.activeSelf)
        {
            key.SetActive(true);
        }
        else
        {
            return;
        }
    }
}
