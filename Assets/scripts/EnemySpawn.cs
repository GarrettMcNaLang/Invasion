using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public static EnemySpawn instance;

     void Awake() {instance = this; }

    //Enemy prefabs
    public static List<GameObject> Prefabs;

    //Enemy spawn root points
    public List<Transform> SpawnPoints;

    //Enemy spawn intervals
    public float spawnInterval = 2f;

    public void StartSpawning()
    {
        //call the spawn coroutine
        StartCoroutine(SpawnDelay());
    }

    IEnumerator SpawnDelay()
    {
        //Call the spawn method
        SpawnEnemy();

        //Wait spawn interval
        yield return new WaitForSeconds(spawnInterval);

        //Recall the same coroutine
        StartCoroutine(SpawnDelay());
    }

    void SpawnEnemy()
    {
        //Randomize the enemy spawn
        int randomPrefabID = Random.Range(0, Prefabs.Count);
        //Randomize the spawn points
        int randomSpawnPointID = Random.Range(0, SpawnPoints.Count);//0-5
        //Instantiate the enemy Prefab
        GameObject spawnedEnemy = Instantiate(Prefabs[randomPrefabID], SpawnPoints[randomSpawnPointID]);
    }

    
}
