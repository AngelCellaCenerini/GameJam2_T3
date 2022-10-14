using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlinkingText : MonoBehaviour
{
    public TextMeshProUGUI targetText;

    public void Start()
    {
        StartCoroutine(FlickerRoutine());
    }

    IEnumerator FlickerRoutine()
    {
        while (true)
        {
            targetText.enabled = true;
            yield return new WaitForSeconds(1f);
            targetText.enabled = false;
            yield return new WaitForSeconds(1f);
        }
    }
}
