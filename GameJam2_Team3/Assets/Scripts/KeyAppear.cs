using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAppear : MonoBehaviour
{
    public GameObject key;
    public GameObject cabinet;
    public bool go;

    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
        go = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cabinet.activeSelf)
        {
            key.SetActive(true);
            go = true;
        }
        else
        {
            return;
        }
    }
}
