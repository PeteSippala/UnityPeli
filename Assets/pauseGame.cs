using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseGame : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private bool isPaused = false;
    public Button ContinueButton;
    public Button Settings;
    public Button QuitGame;
    public Image settingsFrame;
    public Button settingsText;
    public Slider volume1;
    public Slider volume2;
    public Slider volume3;
    public Button mainVolume;
    public Button musicVolume;
    public Button soundEffectVolume;
    public Button getBack;
    

    void Start()
    {
        ContinueButton.onClick.AddListener(ContinueGame);
        Settings.onClick.AddListener(ShowSettingsFrame);
        ContinueButton.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        QuitGame.gameObject.SetActive(false);
        settingsFrame.gameObject.SetActive(false);
        settingsText.gameObject.SetActive(false);
        volume1.gameObject.SetActive(false);
        volume2.gameObject.SetActive(false);
        volume3.gameObject.SetActive(false);
        mainVolume.gameObject.SetActive(false);
        musicVolume.gameObject.SetActive(false);
        soundEffectVolume.gameObject.SetActive(false);
        getBack.gameObject.SetActive(false);
        volume1.value = AudioListener.volume;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;

        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(true);
        }

        ShowButton();

        Debug.Log("Game Paused");
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;

        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(false);
        }

        HideButton();

        Debug.Log("Game Resumed");
    }

    void ContinueGame()
    {
        // Resume the game when the ContinueButton is clicked
        ResumeGame();
    }

    void ShowButton()
    {
        ContinueButton.gameObject.SetActive(true);
        Settings.gameObject.SetActive(true);
        QuitGame.gameObject.SetActive(true);
    }

    void HideButton()
    {
        ContinueButton.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        QuitGame.gameObject.SetActive(false);
        settingsFrame.gameObject.SetActive(false);
        settingsText.gameObject.SetActive(false);
        volume1.gameObject.SetActive(false);
        volume2.gameObject.SetActive(false);
        volume3.gameObject.SetActive(false);
        mainVolume.gameObject.SetActive(false);
        musicVolume.gameObject.SetActive(false);
        soundEffectVolume.gameObject.SetActive(false);
        getBack.gameObject.SetActive(false);
    }
    void ShowSettingsFrame()
    {
        settingsFrame.gameObject.SetActive(true);
        settingsText.gameObject.SetActive(true);
        volume1.gameObject.SetActive(true);
        volume2.gameObject.SetActive(true);
        volume3.gameObject.SetActive(true);
        ContinueButton.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        QuitGame.gameObject.SetActive(false);
        mainVolume.gameObject.SetActive(true);
        musicVolume.gameObject.SetActive(true);
        soundEffectVolume.gameObject.SetActive(true);
        getBack.gameObject.SetActive(true);
        getBack.onClick.AddListener(getBackFromSettings);

    }
    void getBackFromSettings()
    {
        settingsFrame.gameObject.SetActive(false);
        settingsText.gameObject.SetActive(false);
        volume1.gameObject.SetActive(false);
        volume2.gameObject.SetActive(false);
        volume3.gameObject.SetActive(false);
        mainVolume.gameObject.SetActive(false);
        musicVolume.gameObject.SetActive(false);
        soundEffectVolume.gameObject.SetActive(false);
        getBack.gameObject.SetActive(false);
        ContinueButton.gameObject.SetActive(true);
        Settings.gameObject.SetActive(true);
        QuitGame.gameObject.SetActive(true);
    }
    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}
