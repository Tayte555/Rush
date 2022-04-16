using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    private static BulletPool instance;
    public static BulletPool Instance { get { return instance; } }

    public GameObject bulletObject;
    public int bulletAmount = 50;

    private List<GameObject> bulletList;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;

        bulletList = new List<GameObject>();

        for (int i = 0; i < bulletAmount; i++)
        {
            GameObject prefabInstance = Instantiate(bulletObject);
            prefabInstance.transform.SetParent(transform);
            prefabInstance.SetActive (false);

            bulletList.Add(prefabInstance);
        }
    }

    public GameObject GetBullet()
    {
        foreach (GameObject bullet in bulletList)
        {
            if (!bullet.activeInHierarchy)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }
        GameObject prefabInstance = Instantiate(bulletObject);
        prefabInstance.transform.SetParent(transform);
        bulletList.Add (prefabInstance);

        return prefabInstance;
    }
}
