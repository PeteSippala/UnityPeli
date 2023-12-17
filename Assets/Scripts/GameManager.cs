using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Gameplay,
        Paused,
        GameOver,
        LevelUp
    }

    public GameState currentState;

    public GameState previousState;


    [Header("UI")]
    public GameObject pauseScreen;
    public GameObject levelUpScreen;




    [Header("Stopwatch")]
    public float timeLimit;
    float stopwatchTime;
    public Text stopwatchDisplay;



    //Player choosing upgrades
    public bool choosingUpgrade;
       
    void Awake()
    {
        DisableScreens();
    }

    void Update()
    {
        

        switch (currentState)
        {
            case GameState.Gameplay:
                //GamePlay
                CheckForPauseAndResume();
                UpdateStopWatch();
                break;

            case GameState.Paused:
                //Pause
                CheckForPauseAndResume();
                break;

            case GameState.GameOver:
                //Game Over
                break;


        case GameState.LevelUp:
                if(!choosingUpgrade)
                {
                    choosingUpgrade = true;
                    Time.timeScale = 0f;
                    Debug.Log("Upgrading");
                    levelUpScreen.SetActive(true);
                }
                break;

            default:
                Debug.LogWarning("State Does Not Exist");
                break;
        }
    }


    public void ChangeState(GameState newState)
    {
        currentState = newState;
    }

    public void PauseGame()
    {
        if(currentState != GameState.Paused)
        {
            previousState = currentState;
            ChangeState(GameState.Paused);
            Time.timeScale = 0f;
            pauseScreen.SetActive(true);
            Debug.Log("Game is paused");

        }
    }
    
    public void ResumeGame()
    {
        if(currentState == GameState.Paused)
        {
            ChangeState(previousState);
            Time.timeScale = 1f;
            pauseScreen.SetActive(false);
            Debug.Log("Game is resumed");
        }


    }

    void CheckForPauseAndResume()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(currentState == GameState.Paused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void DisableScreens()
    {
        pauseScreen.SetActive(false);
        levelUpScreen.SetActive(false);
    }


    void UpdateStopWatch()
    {
        stopwatchTime += Time.deltaTime;

        UpDateStopwatchDisplay();

        if(stopwatchTime >= timeLimit)
        {
            //GameOver();
        }
    }

    void UpDateStopwatchDisplay()
    {
        int minutes = Mathf.FloorToInt(stopwatchTime / 60);
        int seconds = Mathf.FloorToInt(stopwatchTime % 60);

        stopwatchDisplay.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


    public void StartLevelUp()
    {
        ChangeState(GameState.LevelUp);
    }

    public void EndLevelUp()
    {
        choosingUpgrade = false;
        Time.timeScale = 1;
        levelUpScreen.SetActive(false);
        ChangeState(GameState.Gameplay);
    }
}
