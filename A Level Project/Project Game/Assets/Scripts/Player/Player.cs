using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float playerMaxHealth = 100;
    public float playerHealth;
    public PlayerUI healthBar;

    public GameObject hurtImage;
    public GameObject playerUI;
    public GameObject endScreen;

    public Gun gunScript;
    public PlayerLook lookScript;
    public PlayerScore scoreScript;

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

        if (playerHealth <= 30)
        {
            hurtImage.SetActive(true);
        }

        if (playerHealth <= 0)
        {
            playerUI.SetActive(false);
            endScreen.SetActive(true);

            stopPlay();
            Cursor.visible = true;
        }
    }

    public void stopPlay()
    {
        if(endScreen == isActiveAndEnabled)
        {
            gunScript.canShoot = false;
            lookScript.canLook = false;
        }
    }
}
