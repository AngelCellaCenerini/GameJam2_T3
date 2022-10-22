using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverlayScript : MonoBehaviour
{
    public Camera Camera;
   

    void Start()
    {
        Cursor.visible = false;
        //DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPOS = Camera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPOS.x, cursorPOS.y);
    }
}
