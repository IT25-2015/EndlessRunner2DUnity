using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float speed = 5f;
   // private bool isDead;
    // Start is called before the first frame update
    void Start()
    {
       // isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * -speed * Time.deltaTime);
        Invoke("IsDead", 4f);
    }
    
    void IsDead()
    {
        Destroy(this.gameObject);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" || collision.tag == "Destroyer")
        {
            IsDead();
        }
    }
}
