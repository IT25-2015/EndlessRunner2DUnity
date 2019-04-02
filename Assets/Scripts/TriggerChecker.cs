using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;

public class TriggerChecker : MonoBehaviour
{
    public GameObject platformPrefab;

    void Awake()
    {
        RunnerManager.Checker = this;
    }

    void Start()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!RunnerManager.UIManager.gameOver)
        {
            if (collision.gameObject.tag == "Player")
            {
                Invoke("DestroyPlatform", 0.3f);
            }
        }
    }
    void DestroyPlatform()
    {
        Destroy(transform.gameObject, 2f);
        
    }
}
