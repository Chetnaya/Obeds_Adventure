using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Info2 : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("Game 1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }

    
}
