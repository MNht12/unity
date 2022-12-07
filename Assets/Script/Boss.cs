using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject enemy;
    public float health;

    float timer = 0;
    float timeMove = 0.85f;
    public float speed = 0.2f;
    int step = 0;
    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeMove)
        {
            transform.Translate(new Vector2(speed, 0));
            timer = 0;
            step++;
        }
        if (step == 30)
        {
            speed = -speed;
            step = -31;
        }
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
