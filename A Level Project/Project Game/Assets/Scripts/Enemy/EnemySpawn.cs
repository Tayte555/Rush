using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    private int spawnpointAmount = 6;
    public GameObject[] enemySpawns;

    public GameObject smallEnemy;
    public GameObject mediumEnemy;
    public GameObject largeEnemy;

    
    public int enemiesKilled = 0;
    private int enemyAmount = 0;
    private PlayerWaveNum waveNum;

    // Start is called before the first frame update
    void Start()
    {
        waveNum = FindObjectOfType<PlayerWaveNum>();

        enemySpawns = new GameObject[spawnpointAmount];

        for (int i = 0; i < enemySpawns.Length; i++)
        {
            enemySpawns[i] = transform.GetChild(i).gameObject;
        }

        WaveStart();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesKilled >= enemyAmount)
        {
            NewWave();
        }
    }

    private void SpawnSmallEnemy()
    {
        int spawnPosSmall = Random.Range(0, enemySpawns.Length);
        Instantiate(smallEnemy, enemySpawns[spawnPosSmall].transform.position, enemySpawns[spawnPosSmall].transform.rotation);
    }

    private void SpawnMediumEnemy()
    {
        int spawnPosMedium = Random.Range(0, enemySpawns.Length);
        Instantiate(mediumEnemy, enemySpawns[spawnPosMedium].transform.position, enemySpawns[spawnPosMedium].transform.rotation);
    }

    private void SpawnLargeEnemy()
    {
        int spawnPosLarge = Random.Range(0, enemySpawns.Length);
        Instantiate(largeEnemy, enemySpawns[spawnPosLarge].transform.position, enemySpawns[spawnPosLarge].transform.rotation);
    }
    private void SpawnEnemies()
    {
        int randomNum = Random.Range(0, 3);
        switch (randomNum)
        {
            case 0:
                SpawnSmallEnemy();
                break;
            case 1:
                SpawnMediumEnemy();
                break;
            case 2:
                SpawnLargeEnemy();
                break;
            default: break;
        }
    }

    private void WaveStart()
    {
        waveNum.waveNumber = 1;
        enemiesKilled = 0;
        enemyAmount = 1;
        
        for(int i = 0; i < enemyAmount; i++)
        {
            SpawnEnemies();
        }
    }

    private void NewWave()
    {
        waveNum.waveNumber++;
        enemyAmount += 1;
        enemiesKilled = 0;

        for (int i = 0; i < enemyAmount; i++)
        {
            SpawnEnemies();
        }
    }
}
