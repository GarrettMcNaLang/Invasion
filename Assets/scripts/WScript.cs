using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WScript : towerScript
{
    


    
 new void Start()
    {
        MaxHP = 20;

        health = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Damage(int dmg)
    {
        health -= dmg;
    }
}
