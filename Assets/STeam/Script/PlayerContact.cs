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
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (collision.gameObject.name == "gareki")
            {
                p.TextActive("瓦礫があって先に進むことができない");
            }
              if (collision.gameObject.name == "papername")
            {
                p.TextActive("何かの書類が散らばっている");
            }
                   if (collision.gameObject.name == "gomi")
            {
                p.TextActive("真っ黒なゴミ袋だ...\n何が入っているのだろう...");
            }
            if (collision.gameObject.name == "nikki")
            {
                p.TextActive("日記...?のようだが、文字がかすれて読むことができない");
            }
            if (collision.gameObject.name == "danball")
            {
                p.TextActive("段ボールが散らかっている、授業の教材だろうか");
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (m.opcl == false)
        {
            if (other.GetComponent<Rock>())
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    p.TextActive("鍵が掛かっている…");
                }
            }

            if (other.gameObject.GetComponent<Nazo2>())
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    p.TextActive("底が抜けていて先に進めない。\n何か渡れるようなものがあれば…");
                }
            }
            

        }
    }

}
