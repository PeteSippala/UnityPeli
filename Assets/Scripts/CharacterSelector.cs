using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public static CharacterSelector instance;
    public CharacterScriptableObject characterData;

    void Awake()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.LogWarning("Extra " + this + " Deleted");
            Destroy(gameObject);
        }
    }

    public static CharacterScriptableObject GetData()
    {
        return instance.characterData;
    }

    public void SelectCharacter(CharacterScriptableObject character)
    {
        characterData = character;
        //SceneManager.LoadScene("New_Map");
    }

    public void DestroySingleton()
    {
        instance = null;
        Destroy(gameObject);
    }
}
