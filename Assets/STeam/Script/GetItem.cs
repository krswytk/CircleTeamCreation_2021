using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItem : MonoBehaviour
{
   ItemManager hairetu;
    Flag f;
    int itemnum;


    // Start is called before the first frame update
    void Start()
    {
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

                //アイテム取得フラグ
               itemnum= other.GetComponent<Item>().itemkind;
                f.itemhave[itemnum] = true;
                f.getflag[itemnum] = true;
                Debug.Log(itemnum);

                //アイテム非表示
                other.gameObject.SetActive(false);
                //Destroy(other.gameObject);
            }

        }
    }

}
