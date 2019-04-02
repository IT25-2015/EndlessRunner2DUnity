using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;

public class PlayerChecker : MonoBehaviour
{


    private void Awake()
    {
        RunnerManager.PlayerChecker = this;
    }

    public void ChoosePlayer1()
    {
        RunnerManager.UIManager.spriteNO = 0;
        RunnerManager.SaveGame.playerNO = 0;
    }

    public void ChoosePlayer2()
    {
        RunnerManager.UIManager.spriteNO = 1;
        RunnerManager.SaveGame.playerNO = 1;
    }

    public void ChoosePlayer3()
    {
        RunnerManager.UIManager.spriteNO = 2;
        RunnerManager.SaveGame.playerNO = 2;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
