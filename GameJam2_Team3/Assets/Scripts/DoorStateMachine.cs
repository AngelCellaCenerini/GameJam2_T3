using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DoorStateMachine : MonoBehaviour
{
    // External References
    public GameObject key;
    public GameObject StateA;
    public GameObject StateB;
    public AudioClip Success_Sound;
    AudioSource SuccesSFX;

    void Start()
    {
        StateA.SetActive(true);
        StateB.SetActive(false);
        SuccesSFX = GetComponent<AudioSource>();
    }

    public void KeyCheck()
    {
        if (!key.activeSelf)
        {
            if (StateA.activeInHierarchy)
            {
                SuccesSFX.PlayOneShot(Success_Sound, 0.5f);
            }

            StateA.SetActive(false);
            StateB.SetActive(true);
        }
        else return;
    }
}
