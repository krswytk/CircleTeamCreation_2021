using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nazo2 : MonoBehaviour
{
    [SerializeField]
    GameObject g;
    PanelManager context;
    Menu menu;
    ItemManager manager;
    CursorCtrl cursor;
    Flag f;
    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.Find("Player").GetComponent<Menu>();
        manager = GameObject.Find("Player").GetComponent<ItemManager>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();
        f = GameObject.Find("Player").GetComponent<Flag>();
        context = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();

        if (f.nazoflag[1] == true)
        {
            g.SetActive(true);
            gameObject.SetActive(false);

        }
        else
        {
            gameObject.SetActive(false);
            g.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && menu.opcl == true)
        {
            if (manager.itemkind[cursor.getcursor()] == 3)//種類が０に分類されいているアイテムが選択されたら板3
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    f.nazoflag[1] = true;//謎を解いた
                    manager.useitem();//アイテム消費
                   // g.SetActive(true);//出口出現
                    gameObject.SetActive(false);//謎床非表示
                   context.TextActive("渡ることができるようになった");
                }
            }else
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    context.TextActive("そのアイテムは使用できない");
                }
            }
        }
    }
}
