using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public void SceneChange(string name)
    {
<<<<<<<< HEAD:Assets/Scripts/SceneController.cs
        SceneManager.LoadScene(name);
========
        SceneManager.LoadScene("Character");
>>>>>>>> ec4f1520069a042c269a9b70a51906a192359736:Assets/PlayPressed.cs
    }
}
