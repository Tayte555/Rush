using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float playerMaxHealth = 100;
    public float playerHealth;
    public PlayerUI healthBar;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = playerMaxHealth;
        healthBar.setPlayerMaxHealth(playerMaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damageTaken)
    {
        playerHealth -= damageTaken;
        healthBar.setPlayerHealth(playerHealth);

        if (playerHealth <= 0)
        {
            Debug.Log("Game Over!");
        }
    }
}
