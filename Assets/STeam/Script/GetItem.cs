﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItem : MonoBehaviour
{
    ItemManager hairetu;
    PanelManager Telop;
    Flag f;
   
    int itemnum;

    void Start()
    {
        Telop = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();
         hairetu = GetComponent<ItemManager>();
        f = GetComponent<Flag>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerStay(Collider other)
    {
        //アイテムを取得したら
        if (other.gameObject.tag == "Item")
        {
            if (other.GetComponent<Rock>() == null)
            {
                if (Input.GetKey(KeyCode.Z))
                {
                    //アイテムの持っている画像、アイテム名、アイテム詳細を譲渡
                    hairetu.inputitem(other.GetComponent<Item>().s);
                    hairetu.inputitemname(other.GetComponent<Item>().Itemname);
                    hairetu.inputitemabout(other.GetComponent<Item>().Itemabout);

                    hairetu.incount();//アイテム所持数加算

                    Telop.itempanel(other.gameObject.GetComponent<Item>().Itemname);
                    //Invoke("panelflag", 2.0f);

                    //アイテムフラグ
                    itemnum = other.GetComponent<Item>().itemkind;//番号分けされたアイテムを入手
                    f.getflag[itemnum] = true;//番号分けされたアイテムを非表示にする

                    hairetu.itemkind[hairetu.getcount() - 1] = itemnum;//アイテムの持つ種類番号を配列へ


                    //アイテム非表示
                    other.gameObject.SetActive(false);
                    //Destroy(other.gameObject);
                }
            }

        }
    }

    private void itempanel(string itemname)
    {
        throw new NotImplementedException();
    }

}
