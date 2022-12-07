using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public GameObject enemy3Bullet;
    public GameObject enemy3BulletClone;
    public GameObject enemy;
    public float health;
    public float shootCoolDown = 12f;
    private bool enemyShoot = true;
    public float likelyhood = 3000f;

    void Start()
    {
        enemyShoot = true;
    }

    private void Update()
    {
        if (Random.Range(0f, likelyhood) < 1 && enemyShoot == true)
        {
            enemyShoot = false;
            enemy3BulletClone = Instantiate(enemy3Bullet, new Vector3(enemy.transform.position.x,enemy.transform.position.y - 1f,0), transform.rotation) as GameObject;
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
