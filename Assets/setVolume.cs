using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setVolume : MonoBehaviour
{

    public Slider volume1;

    // Start is called before the first frame update
    void Start()
    {
        volume1.value = AudioListener.volume;
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume; 
    }
}
