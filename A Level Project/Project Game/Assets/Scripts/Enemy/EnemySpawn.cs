using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemySpawns;

    public GameObject smallEnemy;
    public GameObject mediumEnemy;
    public GameObject largeEnemy;

    

    // Start is called before the first frame update
    void Start()
    {
        enemySpawns = new GameObject[3];

        for (int i = 0; i < enemySpawns.Length; i++)
        {
            enemySpawns[i] = transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            SpawnSmallEnemy();
            SpawnMediumEnemy();
            SpawnLargeEnemy();
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
}
