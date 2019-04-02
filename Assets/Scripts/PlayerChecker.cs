using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;

public class PlayerChecker : MonoBehaviour
{
    public int playerChecker = 1;
    // Start is called before the first frame update

    private void Awake()
    {
        RunnerManager.PlayerChecker = this;
    }

    public void ChoosePlayer()
    {
        if(playerChecker == 1)
        {

        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
