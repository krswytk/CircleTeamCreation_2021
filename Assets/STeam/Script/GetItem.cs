using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItem : MonoBehaviour
{
   ItemManager hairetu;
    Flag f;
    int itemnum;
    //public GameObject itemtext = null;
    Panel panel;

    [SerializeField]
    GameObject G;
    // Start is called before the first frame update
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
        if (other.gameObject.tag == "Item")
        {

            if (Input.GetKey(KeyCode.Z))
            {
                //アイテムを取得したら
                hairetu.getitem(other.GetComponent<Item>().s);
                hairetu.incount();

                G.SetActive(true);
                panel.A(other.gameObject.GetComponent<Item>().Itemname);
                Invoke("panelflag", 2.0f);
                //アイテム取得フラグ
                itemnum = other.GetComponent<Item>().itemkind;
                //f.itemhave[itemnum] = true;
                f.getflag[itemnum] = true;

                hairetu.itemkind[hairetu.getcount() - 1] = itemnum;

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
