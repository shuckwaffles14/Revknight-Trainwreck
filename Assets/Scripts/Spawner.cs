using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawners;
    public GameObject enemy;

    private int WaveNo = 0;
    private int NoEnemySpawned = 0;
    private int EnemiesKilled = 0;

    Spawner Spawn;


    private void Start()
    {
        spawners = new GameObject[4];

        for (int i = 0; i < spawners.Length; i++)
        {
            spawners[i] = transform.GetChild(i).gameObject;
        }

        WaveSpawn();  

        
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        int spawnerNo = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[spawnerNo].transform.position, spawners[spawnerNo].transform.rotation);
    }

    private void WaveSpawn()
    {
        WaveNo = 1;
        NoEnemySpawned = 2;
        EnemiesKilled = 0;

        for (int i = 0; i < NoEnemySpawned; i++)
        {
            SpawnEnemy();
        }
    }

    private void NextWave()
    {
        WaveNo++;
        NoEnemySpawned += 1;
        EnemiesKilled = 0;

        for (int i = 0; i < NoEnemySpawned; i++)
        {
            SpawnEnemy();
        }
    }
}
