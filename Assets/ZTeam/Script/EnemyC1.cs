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
    Transform enemybulletT;

    private float timeOut=0.2f;
    private float timeElapsed;
    

    void Start()
    {
        // 敵の体力を初期化
        enemyArmorPoint = 3;
        enemybulletT= new GameObject("enemybullet").transform;
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
       // GetComponent<Status>();
        isPlayerIn = scanplayer.IsPlayerInS();
        if (isPlayerIn == true)
        {
            //ここに敵対行動を書く

            timeElapsed += Time.deltaTime;

            if (timeElapsed >= timeOut)
            {
                InstBullet(transform.position, transform.rotation);

                timeElapsed = 0.0f;
            }
            //Instantiate(enemybullet, transform.position, transform.rotation);
       


            isPlayerIn = false;
            
        }
    }
  

    void InstBullet(Vector3 pos, Quaternion rotation)
    {
        //アクティブでないオブジェクトをbulletsの中から探索
        foreach (Transform t in enemybulletT)
        {
            if (!t.gameObject.activeSelf)
            {
                //非アクティブなオブジェクトの位置と回転を設定
                t.SetPositionAndRotation(pos, rotation);
                //アクティブにする
                t.gameObject.SetActive(true);
                return;
            }
        }
        //非アクティブなオブジェクトがない場合新規生成

        //生成時にbulletsの子オブジェクトにする
        Instantiate(enemybullet, pos, rotation, enemybulletT);
    }
}
