using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Game 1"); //Loads level1
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu"); //Loads menu
    }
    
    public void QuitGame() {
    #if UNITY_STANDALONE
        Application.Quit();
    #endif
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
}
}
