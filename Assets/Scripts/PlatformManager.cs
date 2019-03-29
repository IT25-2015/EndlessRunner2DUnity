using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject platform;
    public Transform generatorPoint;
    public float distanceBetween;

    private float platformWidth;
    private Vector3 pos;

    //za unistavanje
    public float distanceBetweenMin;
    public float distanceBetweenMax;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }

    void Start()
    {
        pos = transform.position;
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(pos.y < generatorPoint.transform.position.y)
        {
           // distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            pos = new Vector3(pos.x, pos.y + platformWidth + distanceBetween, pos.z);
            Instantiate(platform, pos, transform.rotation);
        }
    }
}
