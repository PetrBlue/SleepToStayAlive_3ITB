using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> spawnPoints = new List<GameObject>();
    [SerializeField]
    public List<GameObject> enemies = new List<GameObject>();
    float cooldown;
    float spawnRate = 10f;
    int enemyCount = 1;
    public void Update()
    {
        if(cooldown <= 0)
        {
            cooldown = spawnRate;
            SpawnEnemy(enemyCount++);
        }
        else
        {
            cooldown -= Time.deltaTime;
        }
    }
    public void SpawnEnemy(int count)
    {
        for(int i = 0; i < count; i++)
        {
            int spawnIndex = Random.Range(0, spawnPoints.Count);
            int enemyIndex = ChooseEnemy();
            Instantiate(enemies[enemyIndex], spawnPoints[spawnIndex].transform.position, Quaternion.identity);
        }
    }
    public int ChooseEnemy()
    {
        int rnd = Random.Range(1, 101);
        if(rnd <= 75)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}
