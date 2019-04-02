using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject gameOverButtons;
    [SerializeField] private GameObject scoreObject;
    [SerializeField] private GameObject inGameButtons;
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject shopPanel;
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private GameObject platformPrefab;
    [HideInInspector] public bool isPlay;
    public bool gameOver;
   // public bool gameOverBTN;
    private PlayerManager player;
    public GameObject[] sprites;
    public GameObject sprite;
    public int spriteNO = 0;


    private void Awake()
    {
        RunnerManager.UIManager = this;
    }
    void Start()
    {  
        //gameOver = false;
        //gameOverBTN = false;
        isPlay = false;
        ChooseSprite();
    }

    public void Play()
    {
        ChooseSprite();
        mainMenuPanel.SetActive(false);
        playerPrefab.SetActive(true);
        platformPrefab.SetActive(true);
        gameOverButtons.SetActive(false);
        inGameButtons.SetActive(true);
        scoreObject.SetActive(true);
        isPlay = true;
        InvokeRepeating("SpawnEnemies", 3f, 1.5f);
        sprite.SetActive(true);
       // gameOverBTN = false;
    }

    public void Replay()
    {
        ChooseSprite();
        playerPrefab.SetActive(true);
        gameOverButtons.SetActive(false);
        inGameButtons.SetActive(true);
        RunnerManager.SaveGame.score = 0;
        RunnerManager.PlayerManager.speed = 7f;
        isPlay = true;
        gameOver = false;
        //gameOverBTN = false;
        InvokeRepeating("SpawnEnemies", 3f, 1.5f);
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverButtons.SetActive(true);
        inGameButtons.SetActive(false);
        isPlay = false;
        RunnerManager.EnemyManager.IsDead();
        DestroyEnemies();
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ChooseSprite()
    {
        //spriteNO = RunnerManager.SaveGame.playerNO;
        if(spriteNO != RunnerManager.SaveGame.playerNO)
        sprite = sprites[spriteNO];
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true)
        {
            gameOverButtons.SetActive(true);
            inGameButtons.SetActive(false);
        }
        if (gameOver)
        {
            CancelInvoke();
        }
        SpriteChooser();
    }

    void SpriteChooser()
    {
        spriteNO = GetComponent<SaveGameManager>().playerNO;
        sprite = sprites[spriteNO];
    }

    private IEnumerator WaitAndDeactivate()
    {
        yield return new WaitForSeconds(20f);
        RunnerManager.EnemySpawner.activeEnemies.Remove(RunnerManager.EnemySpawner.enemy);
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

    public void SpawnEnemies()
    {
        if (RunnerManager.UIManager.isPlay)
        {
            int randomNumber;
            randomNumber = Random.Range(1, 10);
            if (randomNumber <= 5)
            {
                RunnerManager.EnemySpawner.SpawnLeft();
            }
            else
            {
                RunnerManager.EnemySpawner.SpawnRight();
            }
        }

    }

    public void BackToMainMenuFromShop()
    {
        mainMenuPanel.SetActive(true);
        shopPanel.SetActive(false);
    }

    public void BackToMainMenuFromGame()
    {
        mainMenuPanel.SetActive(true);
        gameOverButtons.SetActive(false);
        //gameOverBTN = false;
    }

    public void Shop()
    {
        mainMenuPanel.SetActive(false);
        shopPanel.SetActive(true);
    }

    public void DestroyEnemies()
    {
        RunnerManager.EnemySpawner.activeEnemies.Clear();
    }
}
