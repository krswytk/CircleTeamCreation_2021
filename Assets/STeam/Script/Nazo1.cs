using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nazo1 : MonoBehaviour
{
    [SerializeField]
    GameObject g;

    Menu menu;
    Item item;
    ItemManager manager;
    Flag f;

    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.Find("Player").GetComponent<Menu>();
        manager= GameObject.Find("Player").GetComponent<ItemManager>();
        f = GameObject.Find("Player").GetComponent<Flag>();
        item = GameObject.FindGameObjectWithTag("Item").GetComponent<Item>();

        if (f.nazoflag[0] == true)
        {
            g.SetActive(true);
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
            if (/*item.getflag == true && */item.itemkind == 0)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    f.nazoflag[0] = true;
                    g.SetActive(true);
                    manager.useitem();
                }
            }
        }
    }
}
