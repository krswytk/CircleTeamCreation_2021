using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    Flag f;

    //使った後なくなるかどうか
    //public bool itemlost = false;

    //アイテムの画像
    public Sprite s;

    //アイテム番号　絶対よくない…
    public int itemkind;

  
    void Start()
    {
        f = GameObject.Find("Player").GetComponent<Flag>();

        //部屋に入ったらこのアイテムを所持してるか判定
        if (f.getflag[itemkind]==true)
        {
            this.gameObject.SetActive(false);
        }
    }

}
