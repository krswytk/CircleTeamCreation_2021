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
        time = 0f;
        BulletMovement = new Vector2(3.0f, 0.0f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(BulletMovement*Time.deltaTime);
       // rb.AddForce(BulletMovement);
        time += Time.deltaTime;
        if (time > 4f)
        {
            time = 0f;
            gameObject.SetActive(false);
            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Playerに弾が接触したら弾は消滅する
        if (collision.gameObject.tag == "Player")
        {
            time = 0f;
            gameObject.SetActive(false);

        }
    }

    private void OnBecameInvisible()
    {
        //画面外に行ったら非アクティブにする
        time = 0f;
        gameObject.SetActive(false);
    }
    /*
    void BulletState()
    {

        if (BossS.LeftOrRight < 0)//左側にプレイヤー
        {
            
            if (BossS.AttackStateNow == BossS.AttackState.Short)
            {
                BulletMovement = new Vector2(-100.0f, 0.0f);
            }
            else if (BossS.AttackStateNow == BossS.AttackState.Middle)
            {
                BulletMovement = new Vector2(-100.0f, 0.0f);
            }
            else if (BossS.AttackStateNow == BossS.AttackState.Long)
            {
                BulletMovement = new Vector2(-100.0f, 0.0f);
            }

        }
        else if (BossS.LeftOrRight > 0)//右側にプレイヤー
        {

        }
        
    }
    */
}
