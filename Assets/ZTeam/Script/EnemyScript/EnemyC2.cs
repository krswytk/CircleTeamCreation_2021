using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyC2 : MonoBehaviour
{
 

    GameObject Canvas;
    Status Status;
    GameObject pl;//宣言が合っていないと思う
    //float sin;
    private Vector3 PlayerPosition;
    private Vector3 EnemyPosition;

    // Start is called before the first frame update
    void Start()
    {
        pl = GameObject.FindGameObjectWithTag("Player");//ここでプレイヤーを取得したい
        Canvas = GameObject.Find("Canvas");//ステータスの入ったオブジェクトの取得
        Status = Canvas.GetComponent<Status>();//ステータスの取得
        PlayerPosition = pl.transform.position;
        EnemyPosition = this.transform.position;

    }


    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -8)//地面よりも下にいたら消える
        {
            
            Destroy(gameObject);
        }

        //sin = Mathf.Sin(10 * Time.time)+EnemyPosition.y;
        PlayerPosition = pl.transform.position;
        EnemyPosition = transform.position;
        
        //EnemyPosition.y = sin / 2;
        //無理やり跳ねるようにしているがぶるぶるするため、変更したい
        EnemyPosition.y = EnemyPosition.y + 0.05f;
        if (PlayerPosition.x > EnemyPosition.x)
        {
            EnemyPosition.x = EnemyPosition.x + 0.05f;
        }
        else if (PlayerPosition.x < EnemyPosition.x)
        {
            EnemyPosition.x = EnemyPosition.x - 0.05f;
        }
        
        transform.position = EnemyPosition;
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
       // EnemyPosition.y = EnemyPosition.y + 5f;

        if (collision.collider.tag == "mybullet" || collision.collider.tag == "Player")
        {
            Status.statusG += 5;
            Destroy(gameObject);
        }
    }


}
