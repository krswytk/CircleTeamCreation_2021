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
    Vector3 BulletMovement;

        // Start is called before the first frame update
        void Start()
    {
        Canvas = GameObject.Find("Canvas");//キャンバスを検索
        Status = Canvas.GetComponent<Status>();//キャンバスについているステータススクリプトを取得
        player = GameObject.FindGameObjectWithTag("Player").transform;//プレイヤーをタグから取得
        Boss = GameObject.Find("BOSS");//BOSSを検索
        BossS = Canvas.GetComponent<BossS>();//BOSSについているスクリプトを取得

        if (BossS.AttackStateNow == BossS.AttackState.Short)
        {

        }else if (BossS.AttackStateNow == BossS.AttackState.Middle)
        {

        }else if (BossS.AttackStateNow == BossS.AttackState.Long)
        {

        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
