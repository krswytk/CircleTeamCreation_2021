using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nazo2 : MonoBehaviour
{
    PanelManager context;
    Menu menu;
    ItemManager manager;
    CursorCtrl cursor;
    Flag f;

    [SerializeField]
    GameObject ita;

    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.FindGameObjectWithTag("Player").GetComponent<Menu>();
        manager = GameObject.FindGameObjectWithTag("Player").GetComponent<ItemManager>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();
        f = GameObject.FindGameObjectWithTag("Player").GetComponent<Flag>();
        context = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();

        if (f.nazoflag[1] == true)
        {
            // g.SetActive(true);
            gameObject.SetActive(false);
            ita.SetActive(true);

        }
        else
        {
            //gameObject.SetActive(true);

            //g.SetActive(false);
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
                    context.TextActive("渡ることができるようになった");
                    f.nazoflag[1] = true;//謎を解いた
                    manager.useitem();//アイテム消費
                    ita.SetActive(true);
                    gameObject.SetActive(false);//謎床非表示
                    
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    context.TextActive("そのアイテムは使用できない");
                }
            }
        }
    }
}
