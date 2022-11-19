using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {

    public float speed;
    public float increment;
    public float maxY;
    public float minY;

    private Vector2 targetPos;

    public int health;
    //public int scoreDisplay;

    public GameObject moveEffect;
    public Animator camAnim;
    public Text healthDisplay;

    public GameObject spawner;
    public GameObject restartDisplay;
    public GameObject popSound1;

    

    private bool isdead;

    private void Update()
    {
        //to load scene not UI... MIGHT NOT WORK CAUSE SCENE SO YEAH
        if (health <= 0 && !isdead)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene("GameOver");
        }

        
        //TO LOAD SCENE

        // if (health <= 0 && !isdead) {
        //     isdead = true;
        //     spawner.SetActive(false);
        //     GameManager.gameOver()
        //     //restartDisplay.SetActive(true);
        //     Destroy(gameObject);
        // }

        healthDisplay.text = health.ToString();

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY) {

            Instantiate(popSound1,transform.position, Quaternion.identity);
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        }
        
         else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY) {
            Instantiate(popSound1,transform.position, Quaternion.identity);
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }



        
    }
}
