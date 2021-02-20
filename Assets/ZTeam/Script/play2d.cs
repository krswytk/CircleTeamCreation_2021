using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play2d : MonoBehaviour
{
  
    public float speed;//移動速度
    public float jumpSpeed;//ジャンプ力
    public float gravity; //重力　
    public GroundCheck ground; //接地判定
    public float jumpHeight;//高さ制限
    public float jumpLimitTime;//ジャンプ制限時間 
    public GroundCheck head;//頭ぶつけた判定 

    private Rigidbody2D rb = null;
    private bool isGround = false;//地面についているかどうか
    private bool isJump = false;//ジャンプしているかどうか
    private bool isHead = false; //頭が天井にぶつかっているかどうか
    private float jumpPos = 0.0f;//ジャンプした時の位置
    private float jumpTime = 0.0f;//ジャンプの時間制限
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();//2dリジットボディを取得
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }


    void move()
    {
        isGround = ground.IsGround();
        isHead = head.IsGround();

        float horizontalKey = Input.GetAxisRaw("Horizontal");//水平キーの判定
        float verticalKey = Input.GetAxisRaw("Vertical");//↑キーの判定
        float xSpeed = 0.0f;
        float ySpeed = -gravity; //重力で落ち続ける

        if (isGround)
        {
            if (verticalKey > 0)
            {
                ySpeed = jumpSpeed;//unity側で設定した値を代入
                jumpPos = transform.position.y; //ジャンプした位置を記録する
                isJump = true;
                jumpTime = 0.0f; //
            }
            else
            {
                isJump = false;
            }
        }
        else if (isJump)
        {
            //上方向キーを押しているか
            bool pushUpKey = verticalKey > 0;
            //現在の高さが飛べる高さより下か
            bool canHeight = jumpPos + jumpHeight > transform.position.y;
            //ジャンプ時間が長くなりすぎてないか
            bool canTime = jumpLimitTime > jumpTime;
            //上ボタンを押されている。かつ、現在の高さがジャンプした位置から自分の決めた位置より下ならジャンプを継続する
            if (pushUpKey && canHeight && canTime && !isHead)
            {
                ySpeed = jumpSpeed;
                jumpTime += Time.deltaTime;
            }
        
            else
            {
                isJump = false;
                jumpTime = 0.0f; 
            }
        }
        if (horizontalKey > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);

            xSpeed = speed;
        }
        else if (horizontalKey < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);

            xSpeed = -speed;
        }
        else
        {

            xSpeed = 0.0f;
        }
        rb.velocity = new Vector2(xSpeed, ySpeed); //移動の力加え
    }
}

