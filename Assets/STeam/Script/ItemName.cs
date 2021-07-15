﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemName : MonoBehaviour
{
    Text t;

    Menu menu;
    ItemManager manager;
    CursorCtrl cursor;

    void Start()
    {
        t = gameObject.GetComponent<Text>();

        menu = GameObject.FindGameObjectWithTag("Player").GetComponent<Menu>();
        manager = GameObject.FindGameObjectWithTag("Player").GetComponent<ItemManager>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();
    }

    void Update()
    {
        if (menu.opcl == true)
        {
            if (manager.itemname[cursor.getcursor()] != "null")
            {
                t.text = manager.itemname[cursor.getcursor()];
            }
        }
    }
}