using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet : MonoBehaviour
{
    public GameObject self;
    public float speed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Enemy1")
        {
            collision.gameObject.GetComponent<Enemy1>().Damage();
            Destroy(self);
        } 
        if (collision.gameObject.tag == "Enemy2")
        {
            collision.gameObject.GetComponent<Enemy2>().Damage();
            Destroy(self);
        }
        if (collision.gameObject.tag == "Enemy3")
        {
            collision.gameObject.GetComponent<Enemy3>().Damage();
            Destroy(self);
        }
        if (collision.gameObject.tag == "Boss")
        {
            collision.gameObject.GetComponent<Boss>().Damage();
            Destroy(self);
        }
        
        if (collision.gameObject.tag == "BulletEnd") {
            Destroy(self);
        }
    }

    
}
