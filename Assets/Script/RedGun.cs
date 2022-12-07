using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGun : MonoBehaviour
{
    public float likelyhood = 2000f;

    public GameObject enemy1Bullet;
    public GameObject enemy1BulletClone;
    public GameObject gun;


    void Update()
    {
        if (Random.Range(0f, likelyhood) < 1)
        {
            enemy1BulletClone = Instantiate(enemy1Bullet, new Vector3(gun.transform.position.x,gun.transform.position.y - 0,0), transform.rotation) as GameObject;
        }
    }
}
