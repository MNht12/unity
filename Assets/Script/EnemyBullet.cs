using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 1f;
    public GameObject enemyBullet;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerScript>().Damage();
            Destroy(enemyBullet);
        } 
        else if (collision.gameObject.tag == "BulletEnd") {
            Destroy(enemyBullet);
        }
        
    }
}
