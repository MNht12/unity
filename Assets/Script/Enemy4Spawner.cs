using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemy1;

    private bool canSpawn = true;

    private float searchCountDown = 2f;


    public void spawnEnemyWave5()
    {
        for (int i = 0; i < 1; i++)
        {
            Instantiate(enemy1[0], spawnPoints[i].position, transform.rotation);
        }    
    }


}
