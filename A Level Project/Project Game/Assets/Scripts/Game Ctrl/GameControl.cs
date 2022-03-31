using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject SmallEnemy;
    public GameObject MediumEnemy;
    public GameObject LargeEnemy;

    public GameObject[] enemySpawns;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemySpawns = new GameObject[5];

        for (int i = 0; i < enemySpawns.Length; i++)
        {
            enemySpawns[i] = transform.GetChild(i).gameObject;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        int spawnPos = Random.Range(0, enemySpawns.Length);
        Instantiate(SmallEnemy, enemySpawns[spawnPos].transform.position, enemySpawns[0].transform.rotation);

        Instantiate(MediumEnemy, enemySpawns[spawnPos].transform.position, enemySpawns[0].transform.rotation);

        Instantiate(LargeEnemy, enemySpawns[spawnPos].transform.position, enemySpawns[0].transform.rotation);
    }
}
