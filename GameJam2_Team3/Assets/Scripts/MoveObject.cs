using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Animation Variables
    private bool isMoved = false;
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        // Register Mouse Input
        Debug.Log("clicked!");
        // Move Object
        isMoved = true;
        anim.SetBool("isMoved", true);
    }

    public void Move()
    {
        // Register Mouse Input
        Debug.Log("clicked!");
        // Move Object
        isMoved = true;
        anim.SetBool("isMoved", true);
    }
}
