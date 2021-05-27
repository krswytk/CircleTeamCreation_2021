using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC3_s : MonoBehaviour
{
    public GameObject obj;
    private Rigidbody2D rb;
    private float RSpeed=7f;
    private Vector3 axis = new Vector3(0,0,1);

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
        transform.RotateAround(obj.transform.position, axis, RSpeed);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "Player")
         {
            Status.HP(-5);
        }

    }
}
