using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionS : MonoBehaviour
{

    GameObject Canvas;
    Status Status;
    Rigidbody2D rb;
    float PosY;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");//ステータスの入ったオブジェクトの取得
        Status = Canvas.GetComponent<Status>();//ステータスの取得
        rb = GetComponent<Rigidbody2D>();//Rigitbody2Dの取得
        PosY = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, PosY + Mathf.Sin(5 * Time.time) / 8, transform.position.z);
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
