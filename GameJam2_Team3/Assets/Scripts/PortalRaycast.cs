using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using static UnityEngine.EventSystems.EventTrigger;


//Adapted from code found at https://answers.unity.com/questions/1018336/is-there-a-way-to-click-on-a-render-texture-to-sel.html
public class PortalRaycast : MonoBehaviour
{

    public CameraSwitcherV2 CameraSwitcherV2;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 10, Color.red, 10, false);
            Debug.Log($"mouse {Input.mousePosition.x},{Input.mousePosition.y}");
            Debug.Log(ray);
            // do we hit our portal plane?
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject);
                Camera portalCamera = CameraSwitcherV2.CurrentCamera;
                

                var localPoint = hit.textureCoord;
                //Debug.Log(hit);
                Debug.Log($"At {localPoint.x},{localPoint.y}");
                // convert the hit texture coordinates into camera coordinates
                Ray portalRay = portalCamera.ScreenPointToRay(new Vector2(localPoint.x * portalCamera.pixelWidth, localPoint.y * portalCamera.pixelHeight));
                RaycastHit portalHit;
                // test these camera coordinates in another raycast test
                if (Physics.Raycast(portalRay, out portalHit))
                {
                    var trigger = portalHit.collider.gameObject.GetComponent<EventTrigger>();
                    trigger?.OnPointerClick(default);
                    Debug.Log(portalHit.collider.gameObject);
                }
            }
        }

    }
}