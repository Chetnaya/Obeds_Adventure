using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewLevel3 : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("Game 4");
    }


    public void MainMenu()
    {
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

}
