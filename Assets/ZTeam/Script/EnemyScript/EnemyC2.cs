using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyC2 : MonoBehaviour
{
    [SerializeField]
    Transform target=null; //追いかける対象
    NavMeshAgent agent=null;//ナビメッシュエージェント

    GameObject Canvas;
    Status Status;
    GameObject pl;//宣言が合っていないと思う
    private Vector3 PlayerPosition;
    private Vector3 EnemyPosition;

    // Start is called before the first frame update
    void Start()
    {
        pl = GameObject.FindGameObjectWithTag("Player");//ここでプレイヤーを取得したい
        Canvas = GameObject.Find("Canvas");//ステータスの入ったオブジェクトの取得
        Status = Canvas.GetComponent<Status>();//ステータスの取得
        PlayerPosition = pl.transform.position;
        EnemyPosition = transform.position;


    }


    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -8)//地面よりも下にいたら消える
        {

            Status.statusG += 5;
            Destroy(gameObject);
        }
        PlayerPosition = pl.transform.position;
        EnemyPosition = transform.position;

        EnemyPosition.y = EnemyPosition.y + 0.05f;

        if (PlayerPosition.x > EnemyPosition.x)
        {
            EnemyPosition.x = EnemyPosition.x + 0.1f;
        }
        else if (PlayerPosition.x < EnemyPosition.x)
        {
            EnemyPosition.x = EnemyPosition.x - 0.05f;
        }

        if (PlayerPosition.y > EnemyPosition.y)
        {
            EnemyPosition.y = EnemyPosition.y + 0.05f;
        }
        else if (PlayerPosition.y < EnemyPosition.y)
        {
            EnemyPosition.y = EnemyPosition.y - 0.05f;
        }

        transform.position = EnemyPosition;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
     

        if (collision.collider.tag == "mybullet" || collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }


}
