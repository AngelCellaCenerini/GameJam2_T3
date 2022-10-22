using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSecurityOverlayScript : MonoBehaviour
{
    public Camera Camera;
    public Canvas CameraCanvas;

    void Start()
    {
        Cursor.visible = false;
       

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cursorPOS = Camera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(cursorPOS.x, cursorPOS.y, cursorPOS.z); ;


    }
}
