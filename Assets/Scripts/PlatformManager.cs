using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject generatorPrefab;
    [SerializeField] private Transform generatorPoint;
    public float distanceBetween;

    private float platformWidth;
    private Vector3 pos;
    public float seconds;

    // Start is called before the first frame update

    private void Awake()
    {
        RunnerManager.PlatformManager = this;
    }

    void Start()
    {
        pos = generatorPrefab.transform.position;
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(pos.y < generatorPoint.transform.position.y)
        {
            pos = new Vector3(pos.x, pos.y + platformWidth + distanceBetween, pos.z);
            Instantiate(platform, pos, transform.rotation);
        }
    }
   
}
