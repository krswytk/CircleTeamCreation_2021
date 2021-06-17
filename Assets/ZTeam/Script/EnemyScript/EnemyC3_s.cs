using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC3_s : MonoBehaviour
{
    public GameObject Fireball;
    Transform FireballT;
    private float timeOut = 6f;
    private float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
       FireballT = new GameObject("fireball").transform;
    }

    // Update is called once per frame
    void Update()
    {



        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            InstBullet(transform.position, transform.rotation);//弾を生成する

            timeElapsed = 0.0f;
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
}
