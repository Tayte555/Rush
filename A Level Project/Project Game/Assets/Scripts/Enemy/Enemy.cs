using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private string enemyName;
    [SerializeField] private float enemySpeed;
    [SerializeField] private float enemyDamage;
    [SerializeField] private float enemyMaxHealth;
    private float enemyHealth;
    private bool enemyAlive = true;

    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = enemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        enemyMove();
    }

    private void enemyMove()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * enemySpeed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet" && enemyAlive)
        {
            Destroy(collision.gameObject);
            enemyHealth -= 50;
            if (enemyHealth <= 0)
            {
                enemyAlive = false;
                Destroy(gameObject);
            }
        }
    }

}
