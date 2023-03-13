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
    public CastleHealth Health;
    
    // Start is called before the first frame update
    
    void Start()
    {
        
        StartCoroutine(WaveStartDelay());

        GetComponent<CastleHealth>().Init();
        
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
