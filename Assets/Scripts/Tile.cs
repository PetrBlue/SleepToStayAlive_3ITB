using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileData TileData;

    internal void Build(GameObject prefab)
    {
        var bld = Instantiate(prefab, transform);
        bld.transform.localPosition = new Vector3(1, 0, 1);
        TileData.isOccupied = true;
    }

    private void OnMouseDown()
    {
        if(ResourceManager.wood < 10 && ResourceManager.stone < 10)
        {
            return;
        }
        CommandQueue.Instance.EnqueueCommand(new BuildCommand() { 
            prefab = ResourceManager.currentBuilding,
            tile = this
        });
        Debug.Log(ResourceManager.currentBuilding.name);
        ResourceManager.wood -= 10;
        ResourceManager.stone -= 10;
    }
}
