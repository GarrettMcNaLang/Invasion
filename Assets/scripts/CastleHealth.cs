
using UnityEngine;
using UnityEngine.UI;


public class CastleHealth : MonoBehaviour
{


    //The default value of the health count
    public int defaultHC;
    //current health count
    public int HealthCount;

    //Initiate Health system, reset health count

    

    public void Init()
    {
        HealthCount = defaultHC;
        
    }

    //Lose health count
    public void LoseHealth()
    {
        HealthCount--;
        CheckHealthCount();
    }

    private void CheckHealthCount()
    {
        if (HealthCount <1)
        {
            Debug.Log("You lost");
            //Call some reset values and stop the game from the manager
        }
    }
}
