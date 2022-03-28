using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float playerMaxHealth = 100;
    private float playerHealth;




    // Start is called before the first frame update
    void Start()
    {
        playerHealth = playerMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damageTaken)
    {
        playerHealth -= damageTaken;

        if (playerHealth <= 0)
        {
            Debug.Log("Game Over!");
        }
    }

}
