using System;//会話テロップ用追加点
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Tutoriaruinf : MonoBehaviour
{
    [SerializeField]


    public Fungus.Flowchart flowchart = null;//会話テロップ用追加点
    public String sendMessage = "";　　　　　//会話テロップ用追加点

    PanelManager context;
    Menu menu;
    ItemManager manager;
    CursorCtrl cursor;
    Flag f;
    static Flag TF;

    int keyput = 0;
    int huragi =0;//追加フラグ
    int kaku = 0;//追加フラグ
    int menyu = 0;


    // Start is called before the first frame update
    void Start()
    {

        menu = GameObject.FindGameObjectWithTag("Player").GetComponent<Menu>();
        manager = GameObject.FindGameObjectWithTag("Player").GetComponent<ItemManager>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();
        f = GameObject.FindGameObjectWithTag("Player").GetComponent<Flag>();
        context = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();
        TF = GameObject.FindGameObjectWithTag("Player").GetComponent<Flag>();


    }

    // Update is called once per frame
    void Update()
    {

        if (TF.nazoflag[0] == false)
        {
           
              if (huragi == 0)
              {
                String sendMessage = "初め";//会話テロップ用追加点
                flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点

                if (Input.GetKeyUp(KeyCode.Z))
                {
                    huragi++;

                }


            }
                    else  {
                       String sendMessage = "移動";//会話テロップ用追加点
                        flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点

                           if (Input.GetKeyUp(KeyCode.RightArrow) || (Input.GetKeyUp(KeyCode.LeftArrow)))
                           {
                                 keyput = 3;

                                   TF.nazoflag[0] = true;
                                   Debug.Log(keyput);

                           }
                    }
        }
            

        
        if ((TF.nazoflag[0] == true) && (TF.nazoflag[1] == false))
        {
            String sendMessage = "ダッシュ";//会話テロップ用追加点
            flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点
            if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
            {

                TF.nazoflag[1] = true;

            }
        }

        if ((TF.nazoflag[1] == true) && (TF.nazoflag[2] == false))
        {
            String sendMessage = "扉";//会話テロップ用追加点
            flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点

        }



        if ((TF.nazoflag[2] == true) && (TF.nazoflag[3] == false))
        {



            String sendMessage = "アイテム";//会話テロップ用追加点
            flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点
            if (f.getflag[8] == true)
            {

                TF.nazoflag[3] = true;
            }
        }

        if ((TF.nazoflag[3] == true) && (TF.nazoflag[4] == false))
        {


            String sendMessage = "メニュー";//会話テロップ用追加点
            flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点

            if (Input.GetKeyUp(KeyCode.C))
            {

                TF.nazoflag[4] = true;

            }
        }

        if ((TF.nazoflag[4] == true) && (TF.nazoflag[5] == false))
        {

            if (menyu == 0)
            {
                String sendMessage = "閉じる";//会話テロップ用追加点
                flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点
                menyu++;
            }


         

           
            if (Input.GetKey(KeyCode.C))
            {

                TF.nazoflag[5] = true;

            }
        }

        if ((TF.nazoflag[5] == true) && (TF.nazoflag[6] == false))
        {

            if (kaku==0)
            {
                String sendMessage = "書く";//会話テロップ用追加点
                flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点
                kaku++;

            }
          

           



        }

        if ((TF.nazoflag[6] == true) && (TF.nazoflag[7] == false))
        {

            String sendMessage = "終わり";//会話テロップ用追加点
            flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点




            if (Input.GetKey(KeyCode.Z))
            {

                SceneManager.LoadScene("STeam/Scenes/Title_S");

            }



        }




    }

    private void OnTriggerStay(Collider Player)
    {
        if ((TF.nazoflag[1] == true) && (TF.nazoflag[2] == false))
        {

            if (Input.GetKey(KeyCode.Z))
            {
                TF.nazoflag[2] = true;


            }
        }
        if ((TF.nazoflag[4] == true) && (TF.nazoflag[5] == false)|| (TF.nazoflag[5] == true) && (TF.nazoflag[6] == false))
        {

            if (menu.opcl == true)
            {
                if (manager.itemkind[cursor.getcursor()] == 8)//種類が０に分類されいているアイテムが選択されたら板3
                {
                    if (Input.GetKeyUp(KeyCode.Z))
                    {

                        manager.useitem();//アイテム消費
                        TF.nazoflag[6] = true;  //  g.SetActive(true);//出口出現
                                                // gameObject.SetActive(false);//謎床非表示

                    }
                }
            }
           
        }
  




    }





    










}






