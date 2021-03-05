using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    //アイテムを取得したかどうか
    public bool getflag=false;
    //使った後なくなるかどうか
    public bool itemlost = false;
    //アイテムの画像
    public Sprite s;

    //アイテム番号　絶対よくない…
    public int itemkind;

  
    void Start()
    {
        if (getflag == true)
        {
            this.enabled = false;
        }
    }

    public void onflag()
    {
        getflag = true;
    }

}
