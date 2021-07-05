using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC3_bullet_s : MonoBehaviour
{
    public Transform target;
    GameObject Canvas;
    Status Status;
    bool BFire = false;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        Status = Canvas.GetComponent<Status>();
        Destroy(gameObject, 6.0f);
        target= GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        float step = 2f * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            if (BFire == false)
            {
                BFire = true;
                StartCoroutine("Firedamage");//コルーチン使うときに必要
            }
        }
    }

    private IEnumerator Firedamage()
    {
        Status.HP(-2);
        yield return new WaitForSeconds(1.0f);//1秒待つ
        Status.HP(-1);
        yield return new WaitForSeconds(1.0f);//1秒待つ
        Status.HP(-1);
        yield return new WaitForSeconds(1.0f);//1秒待つ
        Status.HP(-1);
        yield return new WaitForSeconds(1.0f);//1秒待つ
        Status.HP(-1);
        yield return new WaitForSeconds(1.0f);//1秒待つ
        Status.HP(-1);

        BFire = false;
    }

 
}
