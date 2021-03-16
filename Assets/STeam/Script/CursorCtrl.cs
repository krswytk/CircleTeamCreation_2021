using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorCtrl : MonoBehaviour
{
    Menu menu;
    ItemManager itemmanager;

    public float a = 9.88f;
   private int cursornum = 0;

    void Start()
    {
        menu = GameObject.Find("Player").GetComponent<Menu>();
        itemmanager = GameObject.Find("Player").GetComponent<ItemManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (menu.opcl == true)
        {
            if (cursornum != itemmanager.getcount() - 1 && itemmanager.getcount()>1)
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    transform.Translate(Screen.width / a, 0f, 0f);
                    cursornum++;
                }

            if (cursornum != 0)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    transform.Translate(-Screen.width / a, 0f, 0f);
                    cursornum--;
                }

            }
        }
    }

    public int getcursor()
    {
        return cursornum;
    }

}
