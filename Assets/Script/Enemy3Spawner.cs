using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemy1;


    public void spawnEnemyWave3()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy1[0], spawnPoints[i].position, transform.rotation);
        }
    }

    public void spawnEnemyWave5()
    {
        for (int i = 3; i < 4; i++)
        {
            Instantiate(enemy1[1], spawnPoints[i].position, transform.rotation);
        }
    }
}
