using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallS : MonoBehaviour
{
    GameObject Player;
    GameObject Canvas;
    Status Status;
   

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player");
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
            if (Status.statusHP > 20)
            {
                Status.HP(-Status.statusHP * 1 / 3);

            }else
            {
                Status.HP(-9);
            }
            Player.transform.position = new Vector3(0f, -1f, -3f);
        }

    }
    }
