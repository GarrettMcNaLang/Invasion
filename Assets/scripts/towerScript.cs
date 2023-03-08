using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerScript : MonoBehaviour
{
    public int MaxHP;

    private int _health;
    public int health
    {
        set
        {
            _health = value;

            //If the health is equal or less than 0, die
            if (health <= 0)
                Die();
        }
        get
        {
            return _health;
        }
    }

    //Set the health to its initial, maximum value, at the beginning of the game
    protected void Start()
    {
        health = MaxHP;
    }
    //The function called when this unit dies
    //protected = gives access to specific classes while inhibiting access from others
    protected virtual void Die()
    {
        Destroy(this.gameObject);
    }



    //The function that tells this unit to receive damage
   public virtual void loseHealth()
    {
        //Decrease health value
        health--;
        
        
        //Check if health is zero
        if (health <= 0)
            Destroy(gameObject);
    }

    

    public virtual void Limit()
    {

    }
}
