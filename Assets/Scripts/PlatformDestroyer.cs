using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{

    public GameObject destroyer;
    private Vector3 pos;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {
        destroyer = GameObject.Find("DestructionPoint");
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        if(pos.y < destroyer.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
