using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WScript : towerScript
{


   
    
 new void Start()
    {
        MaxHP = 20;
        cost = 1;
        health = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
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
