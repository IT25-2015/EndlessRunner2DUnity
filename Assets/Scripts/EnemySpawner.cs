using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject spawnerPrefab;
    public List<GameObject> enemiesToSpawn;
    public List <GameObject> activeEnemies;
    [SerializeField] private float maxPos = 1.35f;
    [SerializeField] private float minPos = -1.23f;
    private Vector3 p;
    [SerializeField] private Transform spawnObject;
    public GameObject enemy;
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
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnLeft()
    {    
         enemyNO = Random.Range(0, 3);
         enemy = enemiesToSpawn[enemyNO];
         activeEnemies.Add(enemy);
         Vector3 enemyPos = new Vector3(minPos, spawnObject.transform.position.y, spawnObject.transform.position.z);
         enemy.transform.position = enemyPos;
         enemy.SetActive(true);
        
    }


    public void SpawnRight()
    {    
         enemyNO = Random.Range(0, 3);
         enemy = enemiesToSpawn[enemyNO];
         activeEnemies.Add(enemy);
         Vector3 enemyPos = new Vector3(maxPos, spawnObject.transform.position.y, spawnObject.transform.position.z);
         enemy.transform.position = enemyPos;
         enemy.SetActive(true);
        }        
 }
