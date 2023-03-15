using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class TowerSpawn : MonoBehaviour
{
    
    //list of tower prefabs that will instantiate
    public List<GameObject> towerPrefab;
    //Transform of the spawning tower(object root)
    public Transform spawntowerRoots;
    //List of towers(UI)
    public List<Image> towerUI;
    //id of tower to spawn
    int spawnID = -1;
    //spawnpoints tilemap
    public Tilemap spawnTileMap;

    void Update()
    {
        if (CanSpawn())
            DetectSpawnPoint();
    }

    bool CanSpawn()
    {
        if (spawnID == -1)
            return false;
        else
            return true;
    }

    void DetectSpawnPoint()
    {
        //Detect when mouse is clicked/touched
        if(Input.GetMouseButtonDown(0))
        { 
        //Get the worldspace position of the mouse
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Gets the integer position of the cell in the tilemap
        var cellposDefault = spawnTileMap.WorldToCell(mousePos);
        //Get the center position of the cell
        var cellposCenter = spawnTileMap.GetCellCenterWorld(cellposDefault);
        //Check if we can spawn in cell(collider)
        if(spawnTileMap.GetColliderType(cellposDefault) == Tile.ColliderType.Sprite)
            {

                //spawn the tower
                SpawnTower(cellposCenter);
                //Disable the collider
                spawnTileMap.SetColliderType(cellposDefault, Tile.ColliderType.None);
                

              
            }
        }
    }
 
    void SpawnTower(Vector3 position)
    {
        GameObject tower = Instantiate(towerPrefab[spawnID], spawntowerRoots);
        tower.transform.position = position;

        DeSelectTower();
    }

    public void RevertCellState(Vector3Int pos)
    {
        spawnTileMap.SetColliderType(pos, Tile.ColliderType.Sprite);
    }
    public void SelectTower(int id)
    {
        DeSelectTower();
        //Set the spawnID
        spawnID = id;
        //Highlight the tower
        towerUI[spawnID].color = Color.white;
    }

    public void DeSelectTower()
    {
        spawnID = -1;
        foreach(var t in towerUI)
        {
            t.color = new Color(0.5f, 0.5f, 0.5f);
        }
    }

}
