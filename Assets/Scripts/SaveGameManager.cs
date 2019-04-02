using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;
using UnityEngine.UI;

public class SaveGameManager : MonoBehaviour
{
    public int score;
    public int highScore;
    [SerializeField] private Text highScoreText;
    [SerializeField] private Text scoreText;

    private void Awake()
    {
        RunnerManager.SaveGame = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;  
        highScore = PlayerPrefs.GetInt("HighScore", highScore);
        InvokeRepeating("ScoreUpdate", 1f, 1f);
    }

    public void SaveScore()
    {
        
    }

    public void LoadScore()
    {

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
                else if (RunnerManager.PlayerManager.speed > 7f)
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

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
        highScoreText.text = "HighScore : " + highScore;
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
