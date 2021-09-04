using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour
{
    //鍵のついたドアなど用のスクリプト
    //ワープするobjに付ける



    public Fungus.Flowchart flowchart;//会話テロップ用追加点
    //public String sendMessage = "";　　　　　//会話テロップ用追加点

    Menu menu;
    ItemManager manager;
    CursorCtrl cursor;
    Flag f;
    PanelManager p;

    public int n;

    private void Start()
    {
        menu = GameObject.FindGameObjectWithTag("Player").GetComponent<Menu>();
        manager = GameObject.FindGameObjectWithTag("Player").GetComponent<ItemManager>();
        f = GameObject.FindGameObjectWithTag("Player").GetComponent<Flag>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();
        p = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();
        flowchart = GameObject.Find("Flowchart").GetComponent<Fungus.Flowchart>();


        switch (n)
        {
            case 0:
                if (f.rockflag[n] == true) Destroy(gameObject.GetComponent<Rock>());
                break;

            case 1:
                if (f.rockflag[n] == true) Destroy(gameObject.GetComponent<Rock>());
                break;

            case 2:
                if (f.rockflag[n] == true) Destroy(gameObject.GetComponent<Rock>());
                break;

            case 3:
                if (f.rockflag[n] == true) Destroy(gameObject.GetComponent<Rock>());
                break;

            case 4:
                if (f.rockflag[n] == true) Destroy(gameObject.GetComponent<Rock>());
                break;

            case 5:
                if (f.rockflag[n] == true) Destroy(gameObject.GetComponent<Rock>());
                break;

            default:
                break;

        }

    }
    //もっと鍵付きなどを増やしていく場合はswitchを使って見やすくする
    private void OnTriggerStay(Collider other)
    {

        if (menu.opcl == true)
        {
            //アイテムの種類3番目を使用した時
            if (SceneManager.GetActiveScene().name == "North rouka")
            {
                if (manager.itemkind[cursor.getcursor()] == 2)
                {
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        Destroy(gameObject.GetComponent<Rock>());

                        String sendMessage = "鍵を開けた";//会話テロップ用追加点
                        flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点

                        // p.TextActive("鍵を開けた");差し替え
                        // manager.useitem();//鍵を消費しない場合はいらない
                        f.rockflag[0] = true;//フラグ
                        menu.opcl = false;
                    }
                }
            }

            if (SceneManager.GetActiveScene().name == "souko")
            {
                if (manager.itemkind[cursor.getcursor()] == 5)
                {
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        Destroy(gameObject.GetComponent<Rock>());
                        String sendMessage = "鍵を開けた";//会話テロップ用追加点
                        flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点

                        // p.TextActive("鍵を開けた");差し替え
                        // manager.useitem();//鍵を消費しない場合はいらない
                        f.rockflag[1] = true;//フラグ

                        menu.opcl = false;
                    }
                }
            }

            if (manager.itemkind[cursor.getcursor()] == 7)
            {
                if (gameObject.name == "Rikasitu")
                {

                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        Destroy(gameObject.GetComponent<Rock>());
                        String sendMessage = "鍵を開けた";//会話テロップ用追加点
                        flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点

                        // p.TextActive("鍵を開けた");差し替え
                        // manager.useitem();//鍵を消費しない場合はいらない
                        f.rockflag[2] = true;//フラグ

                        menu.opcl = false;
                    }
                }

                if (gameObject.name == "Library")
                {

                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        Destroy(gameObject.GetComponent<Rock>());
                        String sendMessage = "鍵を開けた";//会話テロップ用追加点
                        flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点

                        // p.TextActive("鍵を開けた");差し替え
                        // manager.useitem();//鍵を消費しない場合はいらない
                        f.rockflag[3] = true;//フラグ

                        menu.opcl = false;
                    }
                }

                if (gameObject.name == "hokenn")
                {

                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        Destroy(gameObject.GetComponent<Rock>());
                        String sendMessage = "鍵を開けた";//会話テロップ用追加点
                        flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点

                        p.TextActive("鍵を開けた");//差し替え
                                              // manager.useitem();//鍵を消費しない場合はいらない
                        f.rockflag[4] = true;//フラグ

                        menu.opcl = false;
                    }
                }

                if (gameObject.name == "Zyunnbi")
                {

                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        Destroy(gameObject.GetComponent<Rock>());
                        String sendMessage = "鍵を開けた";//会話テロップ用追加点
                        flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点

                        // p.TextActive("鍵を開けた");差し替え
                        // manager.useitem();//鍵を消費しない場合はいらない
                        f.rockflag[5] = true;//フラグ

                        menu.opcl = false;
                    }
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("h");
                String sendMessage = "鍵が掛かっている";//会話テロップ用追加点
                flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点
            }
        }
    }
}