using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATScript : towerScript
{
    
   

    
    // Start is called before the first frame update
 new void Start()
    {
        MaxHP = 15;

        health = MaxHP;

    }


    public override void loseHealth()
    {
        //Decrease health value
        health--;


        //Check if health is zero
        if (health <= 0)
            Destroy(gameObject);
    }
}
