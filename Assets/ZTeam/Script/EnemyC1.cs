using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC1 : MonoBehaviour
{
    // 敵の体力の入れ物
    [SerializeField]
    private int enemyArmorPoint;
    void Start()
    {
        // 敵の体力を初期化
        enemyArmorPoint = 3;
    }

    // 弾オブジェクトと接触したときに呼び出される関数
    void OnCollisionEnter2D(Collision2D collision)
    {
        // もしもtagがbulletであるオブジェクトと接触したら
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
}
