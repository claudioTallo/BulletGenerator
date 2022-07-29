using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float delaySpawn = 1f;
    public float intervalSpawn = 3f;

    void Start()
    {
        InvokeRepeating("SpawnBullet", delaySpawn, intervalSpawn);
    }

    void Update()
    {
        
    }

    private void SpawnBullet()
    {
        //int indexEnemy = Random.Range(0, bulletPrefabs.Length);
        Instantiate(bulletPrefabs, transform);
    }
}
