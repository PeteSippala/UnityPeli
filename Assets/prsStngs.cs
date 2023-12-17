using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prsStngs : MonoBehaviour
{

    public Slider masterVolume;

    // Start is called before the first frame update
    void Start()
    {
        masterVolume.value = AudioListener.volume;
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}
