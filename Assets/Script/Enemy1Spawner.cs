using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemy1;

    private bool canSpawn = true;

    private float searchCountDown = 2f;


    public void spawnEnemyWave1()
    {
        for (int i = 0; i < 22; i++)
        {
            Instantiate(enemy1[0], spawnPoints[i].position, transform.rotation);
        }        
    }

    public void spawnEnemyWave2()
    {
        for (int i = 0; i < 44; i++)
        {
            Instantiate(enemy1[0], spawnPoints[i].position, transform.rotation);
        }        
    }

}
