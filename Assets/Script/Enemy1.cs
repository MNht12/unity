using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public GameObject enemy1Bullet;
    public GameObject enemy1BulletClone;
    public GameObject enemy;
    public float health;
    public float shootCoolDown = 5f;
    private bool enemyShoot = true;
    public float likelyhood = 5000f;

    void Start()
    {
        enemyShoot = true;
    }

    private void Update()
    {
        if (Random.Range(0f, likelyhood) < 1 && enemyShoot == true)
        {
            enemyShoot = false;
            enemy1BulletClone = Instantiate(enemy1Bullet, new Vector3(enemy.transform.position.x,enemy.transform.position.y - 0.5f,0), transform.rotation) as GameObject;
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
