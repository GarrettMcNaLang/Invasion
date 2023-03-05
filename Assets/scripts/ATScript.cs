using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATScript : towerScript
{
    
    public int range;
    public int SInterval; //Time in seconds between shots
    // Start is called before the first frame update
 new void Start()
    {
        MaxHP = 15;

        health = MaxHP;

    }

    // Update is called once per frame
    void UpdateNearestEnemy()
    {
        
    }

    private void Shoot()
    {

    }

    private void Update()
    {
        
    }
    public override void Damage(int dmg)
    {
        health -= dmg;
    }
}
