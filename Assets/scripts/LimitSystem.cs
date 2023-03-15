
using UnityEngine;
using UnityEngine.UI;

public class LimitSystem : MonoBehaviour
{
    //Currency txt UI
    public Text BuildNum;
    //max building values
    public int minBuildings;
    //current building value
    public int BuildVal;

    //Methods:
    //Init(set default values)
    public void Init()
    {
        BuildVal = minBuildings;
    }
    //lose points
    //gain points
    public void Lose(int val)
    {
        BuildVal -= val;
        UpdateUI();
    }
    //Use points
    public bool Use(int val)
    {
        if(belowLimit(val))
        {
            BuildVal += val;
            UpdateUI();
            return true;
        }
        else
        {
        return false;
        }
    }
    //check availability of points
   public bool belowLimit(int val)
    {
        if(val < BuildVal)
            return true;
        else
            return false;
    }
   
    
    //Update text UI
    void UpdateUI()
    {
        BuildNum.text = BuildVal.ToString();
    }
}
