using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgess : MonoBehaviour
{
    private float searchCountDown = 2f;
    
    private int wave = 5;

    public Enemy1Spawner enemy1Spawner;
    public Enemy2Spawner enemy2Spawner;
    public Enemy3Spawner enemy3Spawner;

    void Start()
    {
        
    }

    void Update()
    {
        checkSpawn();
    }

    public void checkSpawn()
    {
        searchCountDown -= Time.deltaTime;
        if (searchCountDown <= 0f)
        {
            searchCountDown = 2f;
            if (GameObject.FindGameObjectWithTag("Enemy1") == null && GameObject.FindGameObjectWithTag("Enemy2") == null && GameObject.FindGameObjectWithTag("Enemy3") == null && wave ==1)
            {
                enemy1Spawner.spawnEnemyWave1();
                wave++;
            }
            if (GameObject.FindGameObjectWithTag("Enemy1") == null && GameObject.FindGameObjectWithTag("Enemy2") == null && GameObject.FindGameObjectWithTag("Enemy3") == null && wave ==2)
            {
                enemy1Spawner.spawnEnemyWave2();
                wave++;
            }
            if (GameObject.FindGameObjectWithTag("Enemy1") == null && GameObject.FindGameObjectWithTag("Enemy2") == null && GameObject.FindGameObjectWithTag("Enemy3") == null && wave ==3)
            {
                enemy1Spawner.spawnEnemyWave1();
                enemy2Spawner.spawnEnemyWave2();
                wave++;
            }
            if (GameObject.FindGameObjectWithTag("Enemy1") == null && GameObject.FindGameObjectWithTag("Enemy2") == null && GameObject.FindGameObjectWithTag("Enemy3") == null && wave ==4)
            {
                enemy1Spawner.spawnEnemyWave1();
                enemy2Spawner.spawnEnemyWave2();
                enemy3Spawner.spawnEnemyWave3();
                wave++;
            }
            if (GameObject.FindGameObjectWithTag("Enemy1") == null && GameObject.FindGameObjectWithTag("Enemy2") == null && GameObject.FindGameObjectWithTag("Enemy3") == null && GameObject.FindGameObjectWithTag("Boss") == null && wave ==5)
            {
                enemy3Spawner.spawnEnemyWave5();
            }
        }
    }

}
