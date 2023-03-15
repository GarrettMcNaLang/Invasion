using System.Collections;

using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    void Awake()
    {
        instance = this;
    }

    public TowerSpawn spawner;
    public healthsystem Health;
    public LimitSystem limit;
   
    
    // Start is called before the first frame update
    
    public void Start()
    {
        
        StartCoroutine(WaveStartDelay());

        GetComponent<healthsystem>().Init();
        GetComponent<LimitSystem>().Init();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    

    IEnumerator WaveStartDelay()
    {
        //wait for x seconds
        yield return new WaitForSeconds(2f);
        //start the enemy spawn
        GetComponent<EnemySpawn>().StartSpawning();
    }
}
