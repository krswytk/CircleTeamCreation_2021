using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC3b_s : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject Canvas;
    Status Status;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Canvas = GameObject.Find("Canvas");
        Status = Canvas.GetComponent<Status>();
 

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
           
            if (Status.FireS==false)
            {
                Status.FireS = true;
            }

        }
    }
}
