using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;

public class EnemyManager : MonoBehaviour
{
    public float speed = 5f;

    private void Awake()
    {
        RunnerManager.EnemyManager = this;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * -speed * Time.deltaTime);
    }
    
    public void IsDead()
    {
        gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" || collision.tag == "EnemyDestroyer")
        {
            IsDead();
        }
    }
}
