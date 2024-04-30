using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class ResourceManager : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> buildings = new List<GameObject>();
    [SerializeField]
    public GameObject player;
    [SerializeField]
    public GameObject camera;
    public static GameObject currentBuilding;
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
            wood+=10;
            stone+=10;
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            PlayerChange();
        }
    }

    private void Start()
    {
        currentBuilding = buildings[0];
    }
    public void GetDifferentPrefab(int index)
    {
        currentBuilding = buildings[index];
    }
    public void PlayerChange()
    {
        player.SetActive(!player.activeSelf);
        if (!player.activeSelf)
        {
            camera.transform.position = new Vector3(14.5f, 28, 13.5f);
            camera.transform.rotation = new Quaternion(0.194710925f, 0.34447974f, -0.0732686967f, 0.915452361f);
            Cursor.visible = true;
            // destroy NewGun_semi(Clone)
            //Destroy();
        }
    }
}
