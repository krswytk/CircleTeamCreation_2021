using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    //鍵のついたドアなど用のスクリプト
    //ワープするobjに付ける

    Menu menu;
    ItemManager manager;
    CursorCtrl cursor;
    Flag f;
    PanelManager p;

    private void Start()
    {
        menu = GameObject.FindGameObjectWithTag("Player").GetComponent<Menu>();
        manager = GameObject.FindGameObjectWithTag("Player").GetComponent<ItemManager>();
        f = GameObject.FindGameObjectWithTag("Player").GetComponent<Flag>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();
        p = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();

        if (f.rockflag[0] == true)
        {
            Destroy(gameObject.GetComponent<Rock>());
        }

    }
    //もっと鍵付きなどを増やしていく場合はswitchを使って見やすくする
    private void OnTriggerStay(Collider other)
    {
        if (menu.opcl == true)
        {
            //アイテムの種類3番目を使用した時
            if (manager.itemkind[cursor.getcursor()] == 2)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    Destroy(gameObject.GetComponent<Rock>());
                    p.TextActive("鍵を開けた");
                   // manager.useitem();//鍵を消費しない場合はいらない
                    f.rockflag[0] = true;//フラグ
                    menu.opcl = false;
                }
            }
        }
    }
}
