using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;
using UnityEngine.UI;

public class SaveGameManager : MonoBehaviour
{
    public int score;
    public int highScore;
    public int playerNO;
    [SerializeField] private Text highScoreText;
    [SerializeField] private Text scoreText;


    private void Awake()
    {
        RunnerManager.SaveGame = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        playerNO = RunnerManager.UIManager.spriteNO;
        score = 0;
        LoadHighScore();
        LoadPlayer();
        InvokeRepeating("ScoreUpdate", 1f, 1f);
    }
    

    void ScoreUpdate()
    {
        if (!RunnerManager.UIManager.gameOver)
       {
            if (RunnerManager.UIManager.isPlay)
            {
                if (RunnerManager.PlayerManager.speed <= 7f)
                {
                    score += 1;
                }
                else if (RunnerManager.PlayerManager.speed > 7f && RunnerManager.PlayerManager.speed < 12)
                {
                    score += 2;
                }
                else if (RunnerManager.PlayerManager.speed >= 12f)
                {
                    score += 3;
                }
            }
        }
    }

    void HighScoreUpdate()
    {
        if(highScore > score)
        {
            highScore = score;
        }
    }

    void SavePlayer()
    {
        PlayerPrefs.SetInt("Player NO", playerNO);
    }

    void LoadPlayer()
    {
        playerNO = PlayerPrefs.GetInt("Player NO", playerNO);
    }

    void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
    }

    void LoadHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore", highScore);
    }


    void Update()
    {
        scoreText.text = "Score : " + score;
        highScoreText.text = "HighScore : " + highScore;
        if (score > highScore)
        {
            highScore = score;
            SaveHighScore();
        }
        SavePlayer();
    }
}
