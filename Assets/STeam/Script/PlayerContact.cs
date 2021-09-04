using System;//会話テロップ用追加点
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerContact : MonoBehaviour
{

    public Fungus.Flowchart flowchart;//会話テロップ用追加点
   // public String sendMessage = "";　　　　　//会話テロップ用追加点

    PanelManager p;
    Menu m;
    Flag f;

    void Start()
    {
        p = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();
        m = this.GetComponent<Menu>();
        f = this.GetComponent<Flag>();
        flowchart = GameObject.Find("Flowchart").GetComponent<Fungus.Flowchart>();
    }


    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (collision.gameObject.name == "gareki")
            {
                String sendMessage = "瓦礫があって先に進むことができない";//会話テロップ用追加点
                flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点

               // p.TextActive("瓦礫があって先に進むことができない");差し替え
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (m.opcl == false)
        {/*
            if (other.GetComponent<Rock>())
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    if (SceneManager.GetActiveScene().name == "souko")
                    {

                        String sendMessage = "鍵がかかっている倉庫";//会話テロップ用追加点
                        flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点
                      //  p.TextActive("鍵がかかっている…\nよく見ると小さな鍵穴がある");
                    }
                    else
                    {
                        String sendMessage = "鍵が掛かっている";//会話テロップ用追加点
                        flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点
                        //p.TextActive("鍵が掛かっている…");


                    }
                }
            }*/

            if (other.gameObject.GetComponent<Nazo2>())
            {
                if (f.nazoflag[1] != true)
                {
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        String sendMessage = "底が抜けていて先に進めない";//会話テロップ用追加点
                        flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点
                        Debug.Log("aaa");
                        //p.TextActive("底が抜けていて先に進めない。\n何か渡れるようなものがあれば…");
                    }
                }
            }
        }

    }
}

