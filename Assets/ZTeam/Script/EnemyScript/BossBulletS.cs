using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletS : MonoBehaviour
{

    GameObject Canvas;//キャンバスを格納するオブジェクト
    Status Status;//ステータススクリプトを格納する変数
    Transform player;//プレイヤーの座標を格納する

    GameObject Boss;
    BossS BossS;
    Vector2 BulletMovement;
    Rigidbody2D rb;
    float time;

        // Start is called before the first frame update
        void Start()
    {
        Canvas = GameObject.Find("Canvas");//キャンバスを検索
        Status = Canvas.GetComponent<Status>();//キャンバスについているステータススクリプトを取得
        player = GameObject.FindGameObjectWithTag("Player").transform;//プレイヤーをタグから取得
        Boss = GameObject.Find("BOSS");//BOSSを検索
        BossS = Boss.GetComponent<BossS>();//BOSSについているスクリプトを取得
        rb = GetComponent<Rigidbody2D>();
        time = 0f;

        if (BossS.LeftOrRight < 0)//左側にプレイヤー
        {
            Debug.Log(BossS.LeftOrRight);
            if (BossS.AttackStateNow == BossS.AttackState.Short)
            {
                BulletMovement = new Vector2(1000.0f, 0.0f);
            }
            else if (BossS.AttackStateNow == BossS.AttackState.Middle)
            {
                BulletMovement = new Vector2(-10000.0f,0.0f);
            }
            else if (BossS.AttackStateNow == BossS.AttackState.Long)
            {
                BulletMovement = new Vector2(100.0f, 0.0f);
            }
            rb.AddForce(BulletMovement, ForceMode2D.Impulse);
        }
        else if (BossS.LeftOrRight > 0)//右側にプレイヤー
        {
            rb.AddForce(BulletMovement, ForceMode2D.Impulse);
        }



    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 3f)
        {
            gameObject.SetActive(false);
            time = 0f;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Playerに弾が接触したら弾は消滅する
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }

    private void OnBecameInvisible()
    {
        //画面外に行ったら非アクティブにする
        gameObject.SetActive(false);
    }
}
