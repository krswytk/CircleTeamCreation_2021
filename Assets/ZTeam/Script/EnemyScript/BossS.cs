using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossS : MonoBehaviour
{

    GameObject Canvas;//キャンバスを格納するオブジェクト
    Status Status;//ステータススクリプトを格納する変数
    Transform player;//プレイヤーの座標を格納する
    GameObject part1, part2, core;





    float dis;//プレイヤーとの距離
    public float LeftOrRight;//正ならプレイヤーは左にいる　負ならプレイヤーは右にいる
    int BossHP = 100;
    bool AttackReady = true;
    float time = 0f;

    //演出の為の変数たち
    float second = 3.0f;
    float RotationAngle = 360f;
    float variation;
    float TotalAngle;

    bool StartOfProduction = false;

    float Part1Zmovement = 0.25f;
    float Part1Zvariation;
    float Part2Zmovement = -0.25f;
    float Part2Zvariation;

    //弾のプール化用オブジェクト
    Transform BulletPool;
    [SerializeField] GameObject bullet;

    //攻撃処理
    Vector3 BulletSpawnPosition;
    Quaternion BulletSpawnRotation;
    bool middlebool = false;


    enum State
    {
        beforebattle,
        wait,
        attack,
        rest,
        defeat,
    }

    State StateNow;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");//キャンバスを検索
        Status = Canvas.GetComponent<Status>();//キャンバスについているステータススクリプトを取得
        StateNow = State.beforebattle;//ステータスを戦闘前に変更
        player = GameObject.FindGameObjectWithTag("Player").transform;//プレイヤーをタグから取得
        core = transform.GetChild(0).gameObject;
        part1 = transform.GetChild(1).gameObject;
        part2 = transform.GetChild(2).gameObject;


        //演出系統
        variation = RotationAngle / second;
        Part1Zvariation = Part1Zmovement / second;
        Part2Zvariation = Part2Zmovement / second;
        StateNow = State.beforebattle;

        //弾を格納するためのゲームオブジェクト生成
        BulletPool = new GameObject("BossBullets").transform;
        
    }
 

    // Update is called once per frame
    void FixedUpdate()
    {
        
        

        dis = Vector3.Distance(player.position, transform.position);
        LeftOrRight = Mathf.Sign(transform.position.x - player.position.x);
        switch (StateNow)
        {
            case State.beforebattle: beforefunc(); break;
            case State.wait: waitfunc(); break;
            case State.attack: attackfunc(); break;
            case State.rest: restfunc(); break;
            case State.defeat: defeatfunc(); break;

        }

        if (BossHP <= 0)
        {
            StateNow = State.defeat;

        }

        // part1.transform.position = new Vector3(3,0,0);

    }

    void HP(int difference)
    {
        BossHP += difference;
    }

    void beforefunc()
    {


        if (StartOfProduction)
        {
            part1.transform.Rotate(0.0f, variation * Time.deltaTime, 0.0f);
            part1.transform.Translate(0.0f, Part1Zvariation * Time.deltaTime, 0.0f);

            part2.transform.Rotate(0.0f, -variation * Time.deltaTime, 0.0f);
            part2.transform.Translate(0.0f, Part2Zvariation * Time.deltaTime, 0.0f);

            TotalAngle += variation * Time.deltaTime;
            if (TotalAngle >= RotationAngle)
            {
                StartOfProduction = false;
                TotalAngle = 0f;
                part1.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                part2.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                StateNow = State.attack;
            }
        }
        else
        {
            if (dis < 4.0f)
            {
                StartOfProduction = true;
            }
        }


    }


    void waitfunc()
    {

    }
    public enum AttackState
    {
        Short,
        Middle,
        Long,
    }

    public AttackState AttackStateNow;


    void attackfunc()
    {
        switch (AttackStateNow)
        {
            case AttackState.Short:
                shortfunc(); break;
            case AttackState.Middle:
                middlefunc(); break;
            case AttackState.Long:
                longfunc(); break;
        }


        if (AttackReady)
        {
            time = 0f;
            if (dis < 3.0f)
            {
                AttackStateNow = AttackState.Short;
            }
            else if (dis < 9.0f)
            {
                AttackStateNow = AttackState.Middle;
            }
            else if (dis >= 9.0f)
            {
                AttackStateNow = AttackState.Long;
            }
            AttackReady = false;

        }
        else
        {
            time += Time.deltaTime;
            if (time > 5f)
            {
                AttackReady = true;
                middlebool = false;
            }
        }
    }

    void restfunc()
    {

    }
    void defeatfunc()
    {
        //倒された処理
    }



    void shortfunc()
    {

       
        Debug.Log("近距離");
        //近距離

    }
    void middlefunc()
    {
        if (middlebool==false)
        {
            BulletSpawnPosition = transform.position;
            BulletSpawnRotation = transform.rotation;
            if (LeftOrRight > 0) {//プレイヤーが左にいる時
                BulletSpawnPosition.x = transform.position.x - 0.3f;
                BulletSpawnRotation.z = transform.rotation.z - 180;
            }
            else if(LeftOrRight < 0)//プレイヤーが右にいる時
            {
                BulletSpawnPosition.x = transform.position.x + 0.3f;
            }
            InstBullet(BulletSpawnPosition, transform.rotation);//test

            middlebool = true;
        }
        Debug.Log("中距離");
        //中距離
    }
    void longfunc()
    {
        Debug.Log("遠距離");
        //遠距離
    }

    void InstBullet(Vector3 pos, Quaternion rotation)
    {
        //アクティブでないオブジェクトをbulletsの中から探索
        foreach (Transform bullet in BulletPool)
        {
            if (!bullet.gameObject.activeSelf)
            {
                //非アクティブなオブジェクトの位置と回転を設定
                bullet.SetPositionAndRotation(pos, rotation);
                //アクティブにする
                bullet.gameObject.SetActive(true);
                return;
            }
        }
        Instantiate(bullet, pos, rotation, BulletPool);//test
    }
}
