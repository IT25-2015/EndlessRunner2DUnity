using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    public GameObject player;
    public Transform playerToFollow;
    public Transform farLeft;
    public Transform farRight;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + offset;
        // transform.position.z = target.position.z - offset;
        if (playerToFollow)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = playerToFollow.position.y;
            newPosition.y = Mathf.Clamp(newPosition.y, farLeft.position.y, farRight.position.y);
            transform.position = newPosition;
        }

    }
}
