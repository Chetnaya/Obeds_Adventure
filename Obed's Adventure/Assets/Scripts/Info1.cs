using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Info1 : MonoBehaviour
{
    public void Skip()
    {
        SceneManager.LoadScene("Game 1");
    }

    public void Next()
    {
        SceneManager.LoadScene("Info2"); 
    }
}
