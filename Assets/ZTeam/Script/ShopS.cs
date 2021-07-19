using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopS : MonoBehaviour
{
    public bool ShopOpen=false;
    GameObject select;
    Transform target;
    Vector3 V;
    float dis;
    // Start is called before the first frame update
    void Start()
    {
        select = GameObject.Find("select");
        target = GameObject.FindGameObjectWithTag("Player").transform;
        select.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (ShopOpen == true)
        {
            dis = Vector3.Distance(target.position, transform.position);
           
            if (dis > 5f)
            {
                ShopOpen = false;
                select.gameObject.SetActive(false);
            }

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ShopOpen == false)
        {
            if (collision.gameObject.tag == "Player")
            {
                select.gameObject.SetActive(true);
                ShopOpen = true;
            }
            
        }
    }
}
