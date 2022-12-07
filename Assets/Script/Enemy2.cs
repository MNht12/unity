using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public GameObject enemy2Bullet;
    public GameObject enemy2BulletClone;
    public GameObject enemy;    
    public float health;
    public float shootCoolDown = 7f;
    private bool enemyShoot = true;
    public float likelyhood = 2500f;

    void Start()
    {
        enemyShoot = true;
    }

    private void Update()
    {
        if (Random.Range(0f, likelyhood) < 1 && enemyShoot == true)
        {
            enemyShoot = false;
            enemy2BulletClone = Instantiate(enemy2Bullet, new Vector3(enemy.transform.position.x,enemy.transform.position.y - 1f,0), transform.rotation) as GameObject;
            StartCoroutine(CoolDown());
        }
    }

    IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(shootCoolDown);
        enemyShoot = true;
    }

    public void Damage()
    {
        health--;
        if (health == 0)
        {
            Destroy(enemy);
        }
    }
}
