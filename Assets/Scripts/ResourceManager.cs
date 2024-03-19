using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class ResourceManager : MonoBehaviour
{
    public static ResourceManager resourceManager
    {
        get
        {
            return resourceManager;
        }
        set
        {
            if(resourceManager == null)
            {
                resourceManager = new ResourceManager();
            }
        }
    }
    public static int wood = 0;
    public static int stone = 0;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wood++;
            stone++;
        }
    }
}
