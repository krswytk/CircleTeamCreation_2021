using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nazo1 : MonoBehaviour
{
    [SerializeField]
    GameObject g;

    Menu menu;
    ItemManager manager;
    Flag f;
    CursorCtrl cursor;

    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.Find("Player").GetComponent<Menu>();
        manager = GameObject.Find("Player").GetComponent<ItemManager>();
        f = GameObject.Find("Player").GetComponent<Flag>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();

        if (f.nazoflag[0] == true)
        {
            g.SetActive(true);
            gameObject.SetActive(false);

        }
        else
        {
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
            if (manager.itemkind[cursor.getcursor()]==0)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    f.nazoflag[0] = true;
                    manager.useitem();
                    g.SetActive(true);
                    gameObject.SetActive(false);
                }
            }
        }
    }
}
