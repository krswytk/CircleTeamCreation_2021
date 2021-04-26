using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItem : MonoBehaviour
{
    ItemManager hairetu;
    PanelManager Telop;
    Flag f;
   // Panel test;
    int itemnum;

    //非表示のパネル(テロップ)取得
   // [SerializeField]
  //  GameObject Telopmanager;
    
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

            if (Input.GetKey(KeyCode.Z))
            {
                hairetu.getitem(other.GetComponent<Item>().s);//アイテムの持っている画像を譲渡
                hairetu.incount();//アイテム所持数加算

                //Telopmanager.SetActive(true);//テロップ表示
                //panel.itemTelop(other.gameObject.GetComponent<Item>().Itemname);
               Telop.itempanel(other.gameObject.GetComponent<Item>().Itemname);
                //Invoke("panelflag", 2.0f);

                //アイテムフラグ
                itemnum = other.GetComponent<Item>().itemkind;
                f.getflag[itemnum] = true;

                hairetu.itemkind[hairetu.getcount() - 1] = itemnum;//アイテムの持つ種類番号を配列へ

                //アイテム非表示
                other.gameObject.SetActive(false);
                //Destroy(other.gameObject);
            }

        }
    }

    private void itempanel(string itemname)
    {
        throw new NotImplementedException();
    }

   // void panelflag()
   // {
    //   Telopmanager.SetActive(false);
   // }
}
