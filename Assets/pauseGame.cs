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

    void Start()
    {
        ContinueButton.onClick.AddListener(ContinueGame);
        ContinueButton.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        QuitGame.gameObject.SetActive(false);
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
    }
}
