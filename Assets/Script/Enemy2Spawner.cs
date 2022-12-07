using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemy1;

    private bool canSpawn = true;

    private float searchCountDown = 2f;


    public void spawnEnemyWave2()
    {
        for (int i = 0; i < 11; i++)
        {
            Instantiate(enemy1[0], spawnPoints[i].position, transform.rotation);
        }    
    }


}
