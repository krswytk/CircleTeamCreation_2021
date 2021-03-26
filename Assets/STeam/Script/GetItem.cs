using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItem : MonoBehaviour
{
    ItemManager hairetu;
    Flag f;
    Panel panel;
    int itemnum;

    //非表示のパネル(テロップ)取得
    [SerializeField]
    GameObject G;
    
    void Start()
    {
        panel = G.GetComponent<Panel>();
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

                G.SetActive(true);//テロップ表示
                panel.A(other.gameObject.GetComponent<Item>().Itemname);
                Invoke("panelflag", 2.0f);

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
    void panelflag()
    {
        G.SetActive(false);
    }
}
