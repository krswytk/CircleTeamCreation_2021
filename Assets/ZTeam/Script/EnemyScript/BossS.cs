using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossS : MonoBehaviour
{

    GameObject Canvas;//キャンバスを格納するオブジェクト
    Status Status;//ステータススクリプトを格納する変数
    Transform player;//プレイヤーの座標を格納する
    float dis;//プレイヤーとの距離
    float LeftOrRight;//正ならプレイヤーは左にいる　負ならプレイヤーは右にいる
    int BossHP=100;
    bool AttackReady;
    float time=0f;

    enum State 
    {
        beforebattle,
        wait,
        attack,
        rest,
        defeat,
    }
    /*
    enum AttackState
    {
        Short,
        Middle,
        Long,
    }
    */
    State StateNow;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");//キャンバスを検索
        Status = Canvas.GetComponent<Status>();//キャンバスについているステータススクリプトを所得
        StateNow = State.beforebattle;//ステータスを戦闘前に変更
        player = GameObject.FindGameObjectWithTag("Player").transform;//プレイヤーをタグから取得
    }

    // Update is called once per frame
    void Update()
    {
        dis = Vector3.Distance(player.position, transform.position);
        LeftOrRight = Mathf.Sign(transform.position.x - player.position.x);
        switch (StateNow)
        {
            case State.beforebattle: beforefunc(); break;
            case State.wait: waitfunc();break;
            case State.attack: attackfunc(); break;
            case State.rest: restfunc(); break;
            case State.defeat: defeatfunc(); break;

        }

        if (BossHP<=0)
        {
            StateNow=State.defeat;
            
        }



    }

    void HP(int difference)
    {
        BossHP += difference;
    }

    void beforefunc()
    {

    }


    void waitfunc()
    {

    }

    void attackfunc()
    {
        if (AttackReady)
        {
            time = 0f;
            if (dis < 3f)
            {
                shortfunc();
            }
            else if (dis < 5f)
            {
                middlefunc();
            }
            else if (dis >= 5f)
            {
                longfunc();
            }
            AttackReady = false;

        }
        else
        {
            time += Time.deltaTime;
            if (time > 5f)
            {
                AttackReady = true;
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
        //近距離
        
    }
    void middlefunc()
    {
        //中距離
    }
    void longfunc()
    {
        //遠距離
    }

}
