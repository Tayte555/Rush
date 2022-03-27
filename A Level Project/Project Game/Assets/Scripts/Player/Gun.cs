using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject Bullet;
    public Camera Camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = Instantiate(Bullet);
            bullet.transform.position = Camera.transform.position + Camera.transform.forward;
            bullet.transform.forward = Camera.transform.forward;
        }
        
    }
}
