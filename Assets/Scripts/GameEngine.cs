using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;

public class GameEngine : MonoBehaviour
{

    private static PlayerManager player;
    private static CamManager cam;
    private static EnemySpawner spawner;
    private static PlatformManager platformManager;
    // Start is called before the first frame update
    void Start()
    {
        RunnerManager.GameEngine = this;
        //RunnerManager.CamManager = this;
        //RunnerManager.EnemySpawner = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ExitGame()
    {
        Application.Quit();
    }

    void StartGame()
    {

    }
}
