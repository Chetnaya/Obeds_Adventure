using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{

    public GameObject gameOverUI;
     
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
}
