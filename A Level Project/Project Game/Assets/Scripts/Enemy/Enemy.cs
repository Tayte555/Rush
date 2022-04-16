using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private string enemyName;
    [SerializeField] private float enemySpeed;
    [SerializeField] private float enemyDamage;
    [SerializeField] private float enemyMaxHealth;
    [SerializeField] private int enemyScore;
    private float enemyHealth;

    private Player playerRef;
    private IEnumerator attack;

    NavMeshAgent navMeshAgent;
    GameObject playerTarget;

    private PlayerScore score;
    private EnemySpawn spawnScript;

    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<PlayerScore>();
        spawnScript = FindObjectOfType<EnemySpawn>();
        
        navMeshAgent = GetComponent<NavMeshAgent>();
        playerTarget = GameObject.FindGameObjectWithTag("Player");
        
        enemyHealth = enemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        enemyMove();
    }

    private void enemyMove()
    {
        navMeshAgent.SetDestination(playerTarget.transform.position);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            collision.gameObject.SetActive(false);
            enemyHealth -= 50;
            if (enemyHealth <= 0)
            {
                Destroy(gameObject);
                score.playerScore += enemyScore;
                Die();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerRef = other.gameObject.GetComponent<Player>();
            playerRef.TakeDamage(enemyDamage);
            
            attack = ConstantAttack();
            StartCoroutine(attack);
        }
    }

    private IEnumerator ConstantAttack()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            playerRef.TakeDamage(enemyDamage);
        }
    }

    void Die()
    {
        spawnScript.enemiesKilled++;
        if (attack != null)
        {
            StopCoroutine(attack);
        }
    }
}