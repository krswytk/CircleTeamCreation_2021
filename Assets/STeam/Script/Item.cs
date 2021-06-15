using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    Flag f;

    public string Itemname = "NULL";
    //アイテムの画像
    public Sprite s;

    //アイテム番号　絶対よくない…
    public int itemkind;

  
    void Start()
    {
        f = GameObject.FindGameObjectWithTag("Player").GetComponent<Flag>();

        //部屋に入ったらこのアイテムを取ったことがあるか判定　アイテム非表示
        if (f.getflag[itemkind]==true)
        {
            this.gameObject.SetActive(false);
        }
    }

}
