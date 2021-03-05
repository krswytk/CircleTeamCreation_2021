using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nazo1 : NazoData
{
    [SerializeField]
    GameObject g;

    Menu menu;
    Item item;
    ItemManager manager;


    // Start is called before the first frame update
    void Start()
    {
        g.SetActive(false);
        menu = GameObject.Find("Player").GetComponent<Menu>();
        manager= GameObject.Find("Player").GetComponent<ItemManager>();
        item = GameObject.FindGameObjectWithTag("Item").GetComponent<Item>();

    }

    // Update is called once per frame
    void Update()
    {
        if (right == true)
            g.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && menu.opcl == true)
        {
            if (item.getflag == true && item.itemkind == 0)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    right = true;
                    manager.useitem();
                }
            }
        }
    }
}
