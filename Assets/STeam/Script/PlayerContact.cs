using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContact : MonoBehaviour
{
    PanelManager p;
    Menu m;

    void Start()
    {
        p = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();
        m = gameObject.GetComponent<Menu>();
    }


    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKey(KeyCode.Z))
        {
            if (collision.gameObject.name == "gareki")
            {
                p.TextActive("瓦礫があって先に進むことができない");
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Rock>()&&m.opcl==false)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                p.TextActive("鍵が掛かっている…");
            }
        }
    }

}
