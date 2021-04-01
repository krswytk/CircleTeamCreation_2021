using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallS : MonoBehaviour
{
    GameObject Canvas;
    Status Status;

    // Start is called before the first frame update
    void Start()
    {
        Status = GetComponent<Status>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("落下判定");
        if (collision.gameObject.tag == "Player")
        {
            Canvas = GameObject.Find("Canvas");
            Status = Canvas.GetComponent<Status>();
            Status.statusHP = Status.statusHP*2/3;
        }

    }
    }
