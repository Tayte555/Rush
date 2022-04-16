using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletVelocity = 100f;
    public float bulletTime = 4f;
    private float bulletTimer;

    // Start is called before the first frame update
    void OnEnable()
    {
        bulletTimer = bulletTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletVelocity * Time.deltaTime;

        bulletTimer -= Time.deltaTime;
        if(bulletTimer <= 0f)
        {
            gameObject.SetActive(false);
        }
        
    }
}
