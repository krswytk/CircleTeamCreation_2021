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

    private void Start()
    {
        menu = GameObject.Find("Player").GetComponent<Menu>();
        manager = GameObject.Find("Player").GetComponent<ItemManager>();
        f = GameObject.Find("Player").GetComponent<Flag>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();

        if (f.nazoflag[1] == true)
        {
            Destroy(gameObject.GetComponent<Rock>());
        }

    }
    //もっと鍵付きなどを増やしていく場合はswitchを使って見やすくする
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && menu.opcl == true)
        {
            //アイテムの種類3番目を使用した時
            if (manager.itemkind[cursor.getcursor()] == 2)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    manager.useitem();//鍵を消費しない場合はいらない
                    f.nazoflag[1] = true;//フラグを新しく作るのが面倒だったので謎として流用
                    Destroy(gameObject.GetComponent<Rock>());
                }
            }
        }
    }
}
