using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionS : MonoBehaviour
{

    GameObject Canvas;
    Status Status;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");//ステータスの入ったオブジェクトの取得
        Status = Canvas.GetComponent<Status>();//ステータスの取得
        rb = GetComponent<Rigidbody2D>();//Rigitbody2Dの取得



    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.collider.tag == "Player")
        {
            Status.HP(25);
            Destroy(gameObject);
        }

    }
}
