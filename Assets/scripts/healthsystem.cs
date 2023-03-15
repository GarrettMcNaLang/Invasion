
using UnityEngine;
using UnityEngine.UI;

public class healthsystem : MonoBehaviour
{
    //UI text for the health count
    public Text HlthNUM;
    //The default value for the health count( used in initiate)
    public int DefaultHealth;
    //current health count
    public int Health;
    // Start is called before the first frame update
    public void Init()
    {
        Health = DefaultHealth;
        HlthNUM.text = Health.ToString();
    }
    //Lose health count
    public void LoseHealth()
    {
        if (Health < 1)
            return;
        Health--;
        HlthNUM.text = Health.ToString();

        CheckHealth();
    }
    //checks health count for losing
    void CheckHealth()
    {
        if(Health < 1)
        {
            Debug.Log("You Lost");
        }
    }
}
