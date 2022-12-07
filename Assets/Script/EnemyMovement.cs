using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float timer = 0;
    float timeMove = 0.85f;
    public float speed = 0.1f;
    int step = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeMove)
        {
            transform.Translate(new Vector2(speed, 0));
            timer = 0;
            step++;
        }
        if (step == 3)
        {
            speed = -speed;
            step = -4;
        }
    }
}
