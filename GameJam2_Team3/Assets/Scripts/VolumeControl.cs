using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class VolumeControl : MonoBehaviour {
    public AudioMixer mixer;
    public void SetLevel (float sliderValue)
    {
        //setFloat "" should be the volume param in mixer you wish to control
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }
}
