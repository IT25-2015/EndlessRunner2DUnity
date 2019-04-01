﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject spawnerPrefab;
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private float maxPos = 1.35f;
    [SerializeField] private float minPos = -1.23f;
    private Vector3 p;
    [SerializeField] private Transform spawnObject;
    int enemyNO;

    private void Awake()
    {
        RunnerManager.EnemySpawner = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawnerPrefab.transform.position;
        spawnerPrefab.transform.position = p;
        //transform.position = p;
        InvokeRepeating("Spawn", 3f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
       // Invoke("EnemyChanger", 1f);
    }

    void SpawnLeft()
    {
        enemyNO = Random.Range(0, 3);
        Vector3 enemyPos = new Vector3(minPos, spawnObject.transform.position.y, spawnObject.transform.position.z);
        Instantiate(enemies[enemyNO], enemyPos, spawnerPrefab.transform.rotation); 
    }

    void SpawnRight()
    {
        enemyNO = Random.Range(0, 3);
        Vector3 enemyPos = new Vector3(maxPos, spawnObject.transform.position.y, spawnObject.transform.position.z);
        Instantiate(enemies[enemyNO], enemyPos, spawnerPrefab.transform.rotation); 
    }

    void Spawn()
    {
        if (RunnerManager.UIManager.isPlay)
        {
            int randomNumber;
            randomNumber = Random.Range(1, 10);
            if (randomNumber <= 5)
            {
                SpawnLeft();
            }
            else
            {
                SpawnRight();
            }
        }
        
    }

  
}
