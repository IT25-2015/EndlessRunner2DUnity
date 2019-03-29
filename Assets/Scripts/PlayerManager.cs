using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using System.Collections;

public class PlayerManager : MonoBehaviour
{

    public float airSpeed;
    private float speed = 5f;
    private Button btn;
    private Rigidbody2D rb;
    private Collider2D wall;

    private void Awake()
    {
    
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
        /*
        if (!jumped)
        {
            if (onRight)
            {
                anim.Play("RunRight");
            }
            else
            {
                anim.Play("RunLeft");
            }
        }*/
    }

    public void MoveLeft()
    {
        
        rb.velocity = new Vector2(-airSpeed, 0);
    }

    public void MoveRight()
    {
        rb.velocity = new Vector2(airSpeed, 0);
    }

    public void SetVelocityZero()
    {
        rb.velocity = Vector2.zero;
    }




}
