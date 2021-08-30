using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossS : MonoBehaviour
{

    GameObject Canvas;//キャンバスを格納するオブジェクト
    Status Status;//ステータススクリプトを格納する変数
    GameObject player;
    play2d Play2D;
    Transform playerTrans;//プレイヤーの座標を格納する
    GameObject part1, part2, core;

   


    float dis;//プレイヤーとの距離
    public float LeftOrRight;//正ならプレイヤーは左にいる　負ならプレイヤーは右にいる
    int BossHP = 100;
    bool AttackReady = true;
    float time = 0f;

    /*演出の為の変数たち
    float second = 3.0f;
    float RotationAngle = 360f;
    float variation;
    float TotalAngle;
    */
    bool StartOfProduction = false;

   

    float BossZmovement = 5f;
    float BossZvariation = 5f;

    //弾のプール化用オブジェクト
    Transform BulletPool;
    [SerializeField] GameObject bullet;

    //攻撃処理
    Vector3 BulletSpawnPosition;
    Quaternion BulletSpawnRotation;

    //近距離用の変数たち
    bool shortbool = false;
    public Animator anim;

    //中距離用の変数たち
    bool middlebool = false;
    float middleTime = 0f;
    int middlecount = 0;
    int randomvalve;

    //遠距離用の変数たち
    bool longbool = false;
    float longTime = 0f;



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

        player = GameObject.Find("player");//playerを検索
        Play2D = player.GetComponent<play2d>();//playerについているスクリプトを取得

        StateNow = State.beforebattle;//ステータスを戦闘前に変更
        playerTrans =player.transform;//プレイヤーのトランスフォームを取得
        core = transform.GetChild(0).gameObject;
        part1 = transform.GetChild(1).gameObject;
        part2 = transform.GetChild(2).gameObject;

     
        StateNow = State.beforebattle;
        anim = GetComponent<Animator>();


        //弾を格納するためのゲームオブジェクト生成
        BulletPool = new GameObject("BossBullets").transform;
        
    }
 

    // Update is called once per frame
    void FixedUpdate()
    {
        dis = Vector3.Distance(playerTrans.position, transform.position);
        LeftOrRight = Mathf.Sign(transform.position.x - playerTrans.position.x);
        switch (StateNow)
        {
            case State.beforebattle: beforefunc(); break;
            case State.wait: Waitfunc(); break;
            case State.attack: Attackfunc(); break;
            case State.rest: Restfunc(); break;
            case State.defeat: Defeatfunc(); break;

        }

        if (BossHP <= 0)
        {
            StateNow = State.defeat;

        }

        

    }

    void HP(int difference)
    {
        BossHP += difference;
    }

    void beforefunc()
    {


        if (StartOfProduction)
        {
            
            if (time == 0f)
            {
                anim.SetTrigger("StartofProduction");
            }else if (time>=4.0f)
            {
               
                StartOfProduction = false;
                time = 0f;
                StateNow = State.attack;
            }
            time += Time.deltaTime;
        }
        else
        {
            if (dis < 4.0f)
            {
                StartOfProduction = true;
            }
        }


    }


    void Waitfunc()
    {

    }
    public enum AttackState
    {
        Short,
        Middle,
        Long,
    }

    public AttackState AttackStateNow;


    void Attackfunc()
    {
        switch (AttackStateNow)
        {
            case AttackState.Short:
                Shortfunc(); break;
            case AttackState.Middle:
                Middlefunc(); break;
            case AttackState.Long:
                Longfunc(); break;
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
            if (time > 6f)
            {
                AttackReady = true;
                middlebool = false;
                middleTime = 0f;
                shortbool = false;
                longTime = 0f;


            }
        }
    }

    void Restfunc()
    {

    }
    void Defeatfunc()
    {
        //倒された処理
    }



    void Shortfunc()
    {
        if (time == 0f)
        {
            anim.SetTrigger("shortAttack");
        }else if (Play2D.isGround == true&&shortbool==false&&time>=2.9f&&time<3.4f)
        {
            Status.HP(-10);
            shortbool = true;
        }else if (time > 4.0f)
        {
            time += 2.0f;
        }
        Debug.Log("近距離");
        //近距離

    }
    void Middlefunc()
    {

        BulletSpawnPosition = transform.position;
        BulletSpawnRotation = transform.rotation;
        middleTime += Time.deltaTime;

        if (LeftOrRight > 0)
            {//プレイヤーが左にいる時
            if (middleTime > 2f)
            {
                middleTime = 0f;
                middlebool = false;
                randomvalve = Random.Range(1, 100);

            }

            if (middlebool == false)
                {
                anim.SetTrigger("middleAttack");
                BulletSpawnPosition.x = transform.position.x - 0.3f;
                if (randomvalve < 50)
                {
                    BulletSpawnRotation.z = transform.rotation.z - 180;
                    InstBullet(BulletSpawnPosition, BulletSpawnRotation);
                    BulletSpawnRotation.z = transform.rotation.z - 210;
                    InstBullet(BulletSpawnPosition, BulletSpawnRotation);
                    
                }
                else
                {
                    BulletSpawnRotation.z = transform.rotation.z - 195;
                    InstBullet(BulletSpawnPosition, BulletSpawnRotation);
                    BulletSpawnRotation.z = transform.rotation.z - 170;
                    InstBullet(BulletSpawnPosition, BulletSpawnRotation);
                    
                }
                   // middlecount++;
                    middlebool = true;
                }
            }

            else if (LeftOrRight < 0)//プレイヤーが右にいる時
            {
            if (middleTime > 2f)
            {
                middleTime = 0f;
                middlebool = false;
                randomvalve = Random.Range(1, 100);
                
            }

            if (middlebool == false)
            {
                anim.SetTrigger("middleAttack");
                BulletSpawnPosition.x = transform.position.x + 0.3f;
                if (randomvalve < 50)
                {
                    InstBullet(BulletSpawnPosition, BulletSpawnRotation);
                    BulletSpawnRotation.z = transform.rotation.z + 30;
                    InstBullet(BulletSpawnPosition, BulletSpawnRotation);
                   
                }
                else
                {
                    BulletSpawnRotation.z = transform.rotation.z + 15;
                    InstBullet(BulletSpawnPosition, BulletSpawnRotation);
                    BulletSpawnRotation.z = transform.rotation.z - 10;
                    InstBullet(BulletSpawnPosition, BulletSpawnRotation);
                    
                }
               // middlecount++;
                middlebool = true;
            }
        }
        Debug.Log("中距離");
        //中距離
    }
    void Longfunc()
    {
        longTime += Time.deltaTime;
        if (longTime >= 0.1f)
        {
            longbool = false;
            longTime = 0f;
           
        }
        if (time < 2.0f && longbool == false)
        {
            BulletSpawnPosition.x = transform.position.x;
            BulletSpawnPosition.y = transform.position.y + 1.0f;
            BulletSpawnRotation.z = transform.rotation.z + 90;
            InstBullet(BulletSpawnPosition, BulletSpawnRotation);
            longbool = true;
        }
        else if (4.0f>time&&time >= 2.0f && longbool == false)
        {
            randomvalve = Random.Range(-30, 30);
            BulletSpawnPosition.x = playerTrans.position.x ; 
            BulletSpawnPosition.y = playerTrans.position.y + 10.0f;
            BulletSpawnRotation.z = transform.rotation.z - 90 + randomvalve;
            InstBullet(BulletSpawnPosition, BulletSpawnRotation);
            longbool = true;
        }

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
                bullet.SetPositionAndRotation(pos, Quaternion.Euler(rotation.x, rotation.y, rotation.z));
                //アクティブにする
                bullet.gameObject.SetActive(true);
                return;
            }
        }
        Instantiate(bullet, pos, Quaternion.Euler(rotation.x, rotation.y, rotation.z), BulletPool);//test
    }
}
