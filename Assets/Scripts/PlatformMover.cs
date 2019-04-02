using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;

public class PlatformMover : MonoBehaviour
{
    private GameObject[] platforms;
    [SerializeField] private float moveSpeed = 5f;
    private double cameraY;
    private float boundHeight;
    // Start is called before the first frame update

    private void Awake()
    {
        platforms = GameObject.FindGameObjectsWithTag("Platform");
        cameraY = Camera.main.gameObject.transform.position.y - 8.5;
        boundHeight = GetComponent<BoxCollider2D>().bounds.size.y;  
    }

    
    void Move()
    {
        Vector3 temp = transform.position;
        temp.y -= moveSpeed * Time.deltaTime;
        transform.position = temp;

    }

    void Reposition()
    {
        if (transform.position.y < cameraY)
        {
            float highestBoundsY = platforms[0].transform.position.y;
            for(int i = 1; i < platforms.Length; i++)
            {
                if(highestBoundsY < platforms[i].transform.position.y)
                {
                    highestBoundsY = platforms[i].transform.position.y;
                }
            }

            Vector3 temp = transform.position;
            temp.y = highestBoundsY + boundHeight +9;
            transform.position = temp;
        }
    }


    void Start()
    {
        
    }

    private void OnEnable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Reposition();
    }
}
