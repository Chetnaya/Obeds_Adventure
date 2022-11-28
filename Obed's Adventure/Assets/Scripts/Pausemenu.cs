using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{

    public GameObject pauseMenuUI;

    public static bool GameIsPaused = false;

    
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
                
            }else
            {
                Pause();
            }
        }
        
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    
    public void QuitGame() {
    #if UNITY_STANDALONE
        Application.Quit();
    #endif
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    }
    // public void QuitGame()
    // {
    //     SceneManager.LoadScene("");

    // }
}
