using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileData TileData;

    public GameObject buildingPrefab;

    internal void Build(GameObject prefab)
    {
        var bld = Instantiate(prefab, transform);
        bld.transform.localPosition = new Vector3(1, 0, 1); // Changed this haha
        TileData.isOccupied = true;
    }

    private void OnMouseDown()
    {
        if(ResourceManager.wood < 10 && ResourceManager.stone < 10)
        {
            return;
        }
        CommandQueue.Instance.EnqueueCommand(new BuildCommand() { 
            prefab = buildingPrefab,
            tile = this
        });
        ResourceManager.wood -= 10;
        ResourceManager.stone -= 10;
    }
}
