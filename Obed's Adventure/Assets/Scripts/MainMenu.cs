using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
   {
    SceneManager.LoadScene("Info1"); //Loads level1
    
   }

   public void SelectLevel()
   {
    SceneManager.LoadScene("SelectLevel"); //Loads level1
    
   }
   public void AboutScene()
   {
    SceneManager.LoadScene("About"); //Loads level1
    
   }

//    public void QuitGame()
//    {
//     Application.Quit();
//    }



   public void QuitGame() {
    #if UNITY_STANDALONE
        Application.Quit();
    #endif
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
}

   
}
