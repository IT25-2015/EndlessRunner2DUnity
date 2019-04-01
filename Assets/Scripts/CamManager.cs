using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Runner;

public class CamManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform playerToFollow;
    [SerializeField] private Transform farLeft;
    [SerializeField] private Transform farRight;
    [SerializeField] private GameObject mainCamera;

    private Vector3 offset;
    // Start is called before the first frame update

    private void Awake()
    {
        RunnerManager.CamManager = this;
    }
    void Start()
    {
        offset = mainCamera.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerToFollow)
        {
            Vector3 newPosition = mainCamera.transform.position;
            newPosition.y = playerToFollow.position.y;
            newPosition.y = Mathf.Clamp(newPosition.y, farLeft.position.y, farRight.position.y);
            mainCamera.transform.position = newPosition;
        }

    }
}
