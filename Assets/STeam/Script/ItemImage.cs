using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemImage : MonoBehaviour
{ 
    Menu menu;
    ItemManager manager;
    CursorCtrl cursor;

    [SerializeField]
    GameObject g;

    void Start()
    {
        menu = GameObject.FindGameObjectWithTag("Player").GetComponent<Menu>();
        manager = GameObject.FindGameObjectWithTag("Player").GetComponent<ItemManager>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();
    }

    void Update()
    {
        if (menu.opcl == true)
        {
            
            if (manager.itemname[cursor.getcursor()] == "map")
            {
                //Debug.Log(cursor.getcursor());
                this.GetComponent<Image>().enabled = true;
                this.GetComponent<Image>().sprite = g.transform.GetChild(cursor.getcursor()).GetComponent<Image>().sprite;
                
            }
            else this.GetComponent<Image>().enabled = false;
        }
    }
}
