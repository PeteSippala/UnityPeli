using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressSettings : MonoBehaviour
{
    
    public void OnButtonClicked()
    {
        SceneManager.LoadScene("SettingsScene");
    }

   
}