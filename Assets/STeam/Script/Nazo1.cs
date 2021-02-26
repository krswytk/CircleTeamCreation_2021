using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nazo1 : NazoData
{
    [SerializeField]
    GameObject g;

    Menu m;
    Item i;


    // Start is called before the first frame update
    void Start()
    {
        g.SetActive(false);
        m = GameObject.FindWithTag("Player").GetComponent<Menu>();
        i = GameObject.FindWithTag("Item").GetComponent<Item>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (right == true)
            g.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && m.opcl == true)
        {
            if (i.getflag == true && i.itemkind == 0)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    right = true;
                }
            }
        }
    }
}
