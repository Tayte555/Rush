using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Camera Camera;
    
    public bool canShoot;
    
    private float fireRate = 0.15f;
    private float lastBulletTime;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && (canShoot == true))
        {
            Shoot();
        }
    }

    private void BulletSpawn()
    {
        GameObject bullet = BulletPool.Instance.GetBullet();
        bullet.transform.position = Camera.transform.position + Camera.transform.forward;
        bullet.transform.forward = Camera.transform.forward;

        lastBulletTime = Time.time;
    }

    private void Shoot()
    {
        if(Time.time - lastBulletTime >= fireRate)
        {
            BulletSpawn();
        }
    }
}