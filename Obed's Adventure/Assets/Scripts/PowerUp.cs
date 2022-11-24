using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
   //public PowerUpEffect powerupEffect;
   public float speed;

   public GameObject effect;
   public GameObject popupSound;

   void Update()
   {
    transform.Translate(Vector2.left * speed * Time.deltaTime);
   }

   public void OnTriggerEnter2D(Collider2D other)
   {
    {
        if (other.CompareTag("Player")){
            //To increase the health of the player
            other.GetComponent<Player>().health++;
            //To destroy the game object
            Destroy(gameObject);
            //For Audio
            Instantiate(popupSound,transform.position, Quaternion.identity);
            //To apply Particle effect
            Instantiate(effect, transform.position, Quaternion.identity);
        }
        
        
        
        
    }
   }
}