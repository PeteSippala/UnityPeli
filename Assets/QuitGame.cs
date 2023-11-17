using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    
    public Button QuitButton;

    // Start is called before the first frame update
    public void OnButtonClicked()
    {
        
        QuitButton.onClick.AddListener(QuitPeli);
    }

    
    void QuitPeli()
    {
       
        Application.Quit();
    }
}
