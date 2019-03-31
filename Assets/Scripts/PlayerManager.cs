using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using System.Collections;
using Runner;

public class PlayerManager : MonoBehaviour
{

    [HideInInspector] public float airSpeed = 7f;
    [HideInInspector] public float speed = 7f;
    //public UIManager ui;
    private Rigidbody2D rb;
    Vector3 position;
    //public GameObject playerPrefab;
    bool isDead;
    //private Vector2 vel;

    private void Awake()
    {
        RunnerManager.PlayerManager = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        position = transform.position;
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        StartCoroutine(StartCountdown());
        transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World); 
    }

    float currCountdownValue = 0;
    public IEnumerator StartCountdown(float countdownValue = 160)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
            TimeChecker();
        }
    }

    void TimeChecker()
    {
        if (currCountdownValue < 140)
        {
            speed = 7f;
            airSpeed = 7f;
        }
        if (currCountdownValue < 120)
        {
            speed = 9f;
            airSpeed = 9f;
        }
        if (currCountdownValue < 90)
        {
            speed = 12f;
            airSpeed = 12f;
        }
    }

    public void MoveLeft()
    {
        rb.velocity = new Vector2(-airSpeed, 0);
    }

    public void MoveRight()
    {
        rb.velocity = new Vector2(airSpeed, 0);
    }

    public void SetVelocityZero()
    {
        rb.velocity = Vector2.zero;
    }

    void IsDead()
    {
        gameObject.SetActive(false);
        isDead = true;
        RunnerManager.UIManager.gameOver = true;
    }

    void SpawnPlayer()
    {
        isDead = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            IsDead();
        }
    }
}
