using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC1 : MonoBehaviour
{
    [SerializeField]
    private GameObject enemybullet;
    
    [SerializeField]
    private int enemyArmorPoint;// 敵の体力の入れ物


    public ScanPlayer scanplayer;
    private bool isPlayerIn = false;//playerが範囲内にいるかどうか
    private int numberOfEnemys = 0;
    void Start()
    {
        // 敵の体力を初期化
        enemyArmorPoint = 3;
    }

    // 弾オブジェクトと接触したときに呼び出される関数
    void OnCollisionEnter2D(Collision2D collision)
    {
        // もしもtagがmybulletであるオブジェクトと接触したら
        if (collision.gameObject.tag == "mybullet")
        {
           
            // 敵の体力が0以上だったら
            if (enemyArmorPoint > 0)
            {
                // 敵の体力を1削る
                enemyArmorPoint -= 1;
            }
            else {
                // 敵の体力が0になったら敵オブジェクトを消滅させる
                
                Destroy(gameObject);
            }
        }
    }

    void Update()
    {
        isPlayerIn = scanplayer.IsPlayerInS();
        if (isPlayerIn == true)
        {
            //ここに敵対行動を書く
            Invoke("Call", 3f);
            Instantiate(enemybullet, transform.position, transform.rotation);

            isPlayerIn = false;
            
        }
    }
    void Call()
    {
        Debug.Log("実行されました。");
    }

}
