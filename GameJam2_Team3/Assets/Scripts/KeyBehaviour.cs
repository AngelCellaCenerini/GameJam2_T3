using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class KeyBehaviour : MonoBehaviour
{
    // External References
    public AudioClip Collectible_SFX;
    AudioSource CollectedSFX;
    public bool isSelected;

    void Start()
    {
        CollectedSFX = GetComponent<AudioSource>();
        isSelected = false;
    }

    public void OnMouseDown()
    {
        // Collect Object
        CollectedSFX.PlayOneShot(Collectible_SFX, 0.5f);
        isSelected = true;

    }

}
