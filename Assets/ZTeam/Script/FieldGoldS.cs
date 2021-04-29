using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGoldS : MonoBehaviour
{
    GameObject Canvas;
    Status Status;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Canvas = GameObject.Find("Canvas");
        Status = Canvas.GetComponent<Status>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Status.GOLD(10);

                Destroy(gameObject);
        }
    }
}
