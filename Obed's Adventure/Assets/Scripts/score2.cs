using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score2 : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
        
        if(score >= 30)
        {
            SceneManager.LoadScene("NewLevel(fromGame2");
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Destroy(other.gameObject);
    }
}
