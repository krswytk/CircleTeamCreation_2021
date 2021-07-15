using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC3_s : MonoBehaviour
{
    public Transform target;
    public GameObject Fireball;
    Transform FireballT;
    private float timeOut = 6f;
    private float timeElapsed;

    private int enemyArmorPoint;// 敵の体力の入れ物
    GameObject Canvas;
    Status Status;


    // Start is called before the first frame update
    void Start()
    {
       FireballT = new GameObject("fireball").transform;
        target = GameObject.FindGameObjectWithTag("Player").transform;



        enemyArmorPoint = 5;
        Canvas = GameObject.Find("Canvas");
        Status = Canvas.GetComponent<Status>();
    }

    // Update is called once per frame
    void Update()
    {
        float step = 0.75f * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            InstBullet(transform.position, transform.rotation);//弾を生成する

            timeElapsed = 0.0f;
        }

        if (enemyArmorPoint <= 0)
        {
            Status.statusG += 10;
            Destroy(gameObject); // 敵の体力が0になったら敵オブジェクトを消滅させる
        }
    }

    void InstBullet(Vector3 pos, Quaternion rotation)
    {
        //アクティブでないオブジェクトをbulletsの中から探索
        foreach (Transform t in FireballT)
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
        Instantiate(Fireball, pos, rotation, FireballT);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        // もしもtagがmybulletであるオブジェクトと接触したら
        if (collision.gameObject.tag == "mybullet")
        {

            ENHP(Status.attackP);
        }
    }

    public void ENHP(int damage)
    {
        // 敵の体力を削る
        enemyArmorPoint -= damage;
        Debug.Log(enemyArmorPoint);
    }
}
