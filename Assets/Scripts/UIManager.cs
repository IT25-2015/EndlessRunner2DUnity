﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject gameOverButtons;
    [SerializeField] private GameObject scoreObject;
    [SerializeField] private GameObject inGameButtons;
    [SerializeField] private GameObject mainMenuPanel;
    //[SerializeField] private GameObject gamePanel;
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private GameObject platformPrefab;
    [HideInInspector] public bool isPlay;
    int score;
    public bool gameOver;
    private PlayerManager player;
    //public Button[] buttons;

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
        isPlay = false;
    }
    void ScoreUpdate()
    {
        if (!gameOver)
        {
            if (isPlay)
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
    }
    public void Play()
    {
        mainMenuPanel.SetActive(false);
        playerPrefab.SetActive(true);
        platformPrefab.SetActive(true);
        gameOverButtons.SetActive(true);
        gameOverButtons.SetActive(false);
        inGameButtons.SetActive(true);
        scoreObject.SetActive(true);
        //gamePanel.SetActive(true);
        isPlay = true;
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
        if(gameOver == true)
        {
            gameOverButtons.SetActive(true);
            inGameButtons.SetActive(false);
        }
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
