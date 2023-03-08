using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
   
    //Health, damage, move speed
    
    public int health, attackpower;
    public float movespeed;

   

    void Update()
    {
        Move();
    }
    //moving up

    void Move()
    {
        transform.Translate(transform.up*movespeed*Time.deltaTime);
    }

    //Lose health

    void loseHealth()
    {
        //Decrease health value
        health--;
        //Blink Red 
        StartCoroutine(blinkRed());
        //Check if health is zero
        if(health <= 0)
            Destroy(gameObject);
    }

   

    IEnumerator blinkRed()
    {
        //change the sprite renderer to red
        GetComponent<SpriteRenderer>().color = Color.red;
        //wait a small amount of time
        yield return new WaitForSeconds(0.2f);
        //revert to original color
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
