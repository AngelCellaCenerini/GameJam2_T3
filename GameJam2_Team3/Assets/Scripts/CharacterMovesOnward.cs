using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovesOnward : MonoBehaviour
{

    public Transform objectPosition;
    public GameObject victimInteractedWith;


    public float moving;

    //For code for the transform, got it from: https://www.youtube.com/watch?v=-thhMXmTM7Q
    //Code is subject to change after playtesting as we are thinking of how the rooms and objects are going to function
    //key and door

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //When the key is grabbed, move the character and play animation
        if (victimInteractedWith.activeSelf == false)
        {
            Vector3 v = transform.position;
            Vector3 o = objectPosition.position;
            transform.position = Vector3.Lerp(v, o, moving);
        }
    }
}
