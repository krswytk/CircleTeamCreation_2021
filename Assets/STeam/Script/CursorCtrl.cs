using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorCtrl : MonoBehaviour
{
    Menu menu;
    ItemManager itemmanager;

    //カーソル画像の座標変数
    public float a = 9.88f;

    //現在のカーソルで選択している番号
    private int cursornum = 0;

    void Start()
    {
        menu = GameObject.FindGameObjectWithTag("Player").GetComponent<Menu>();
        itemmanager = GameObject.FindGameObjectWithTag("Player").GetComponent<ItemManager>();
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
    //カーソル番号
    public int getcursor()
    {
        return cursornum;
    }

}
