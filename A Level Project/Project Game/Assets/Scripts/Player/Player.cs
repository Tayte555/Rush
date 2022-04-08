using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float playerMaxHealth = 100;
    public float playerHealth;
    public PlayerUI healthBar;

    public GameObject playerUI;
    public GameObject endScreen;

    public Gun gunScript;
    public PlayerLook lookScript;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = playerMaxHealth;
        healthBar.setPlayerMaxHealth(playerMaxHealth);

        gunScript = FindObjectOfType<Gun>();
        lookScript = FindObjectOfType<PlayerLook>();
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
            gunScript.canShoot = false;
            lookScript.canLook = false;
            
            playerUI.SetActive(false);
            endScreen.SetActive(true);
            
            Cursor.visible = true;
        }
    }
}
