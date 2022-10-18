using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class KeyBehaviour : MonoBehaviour
{
    // External References
    public AudioClip Collectible_SFX;
    AudioSource CollectedSFX;

    void Start()
    {
        CollectedSFX = GetComponent<AudioSource>();
    }

    public void OnMouseDown()
    {
        // Collect Object
        CollectedSFX.PlayOneShot(Collectible_SFX, 0.5f);
        gameObject.SetActive(false);
    }

}
