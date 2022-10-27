using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnding : MonoBehaviour
{

    public GameObject roomDoor;
    // Start is called before the first frame update

    // Update is called once per frame
    public void EndGame()
    {
        if (roomDoor.activeSelf)
        {
            SceneManager.LoadScene(1);
        }
    }
}
