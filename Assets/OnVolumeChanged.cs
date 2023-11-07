using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OnVolumeChanged : MonoBehaviour
{
    public Slider masterVolume;

    private void Start()
    {
        
        masterVolume.value = AudioListener.volume;
    }

    public void VolumeChanged()
    {
        AudioListener.volume = masterVolume.value;
    }
}
