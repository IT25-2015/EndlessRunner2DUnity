using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    int score;
    public bool gameOver;
    //public Button[] buttons;
    public GameObject gameOverButtons;
    public GameObject inGameButtons;
    PlayerManager player;

    private void Awake()
    {
        RunnerManager.UIManager = this;
    }
    void Start()
    {
        score = 0;
        gameOver = false;
        InvokeRepeating("ScoreUpdate", 1f, 1f);
        player = GetComponent<PlayerManager>();
    }
    void ScoreUpdate()
    {
        if (!gameOver)
        {
            if (player.speed <= 7f)
            {
                score += 1;
            }
            if (player.speed > 7f && player.speed < 12f)
            {
                score += 2;
            }
            if (player.speed >= 12f)
            {
                score += 3;
            } 
        }
    }
    public void Play()
    {
        //Application.LoadLevel("Menu");
    }

    public void GameOver()
    {
        gameOver = true;
        //gameOverButtons.gameObject.SetActive(true);
        //inGameButtons.gameObject.SetActive(false);
        gameOverButtons.SetActive(true);
        inGameButtons.SetActive(false);
        /*
        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
    }

    public void Pause()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}
