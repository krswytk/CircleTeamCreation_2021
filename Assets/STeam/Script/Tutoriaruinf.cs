using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Tutoriaruinf : MonoBehaviour
{
    [SerializeField]

    PanelManager context;
    Menu menu;
    ItemManager manager;
    CursorCtrl cursor;
    Flag f;
    static Flag TF;

    int keyput = 0;

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
            Debug.Log("debug comment");
            context.TextActive("左右の矢印キーで移動");

            if (Input.GetKeyUp(KeyCode.RightArrow) || (Input.GetKeyUp(KeyCode.LeftArrow)))
            {
                keyput = 3;

                TF.nazoflag[0] = true;
                Debug.Log(keyput);

            }
        }

        if ((TF.nazoflag[0] == true) && (TF.nazoflag[1] == false))
        {
            context.TextActive("Shift+左右の矢印キーでダッシュ移動");
            if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
            {

                TF.nazoflag[1] = true;

            }
        }

        if ((TF.nazoflag[1] == true) && (TF.nazoflag[2] == false))
        {
            context.TextActive("扉の前で決定キー(Z)で部屋にはいれる");

        }



        if ((TF.nazoflag[2] == true) && (TF.nazoflag[3] == false))
        {




            context.TextActive("アイテムの前で決定キー(Z)でアイテムを所得できる");
            if (f.getflag[8] == true)
            {

                TF.nazoflag[3] = true;
            }
        }

        if ((TF.nazoflag[3] == true) && (TF.nazoflag[4] == false))
        {

            context.TextActive("筆記用具を手に入れた\nCキーでアイテムを確認でき,再度Cキーで行動可能　");

            if (Input.GetKeyUp(KeyCode.C))
            {

                TF.nazoflag[4] = true;

            }
        }

        if ((TF.nazoflag[4] == true) && (TF.nazoflag[5] == false))
        {

            context.TextActive("筆記用具を手に入れた\nCキーでアイテムを確認でき,再度Cキーで行動可能\nメニューを閉じるところまでやってみよう　");

            if (Input.GetKey(KeyCode.C))
            {

                TF.nazoflag[5] = true;

            }
        }

        if ((TF.nazoflag[5] == true) && (TF.nazoflag[6] == false))
        {

            context.TextActive("ノートに筆記用具で絵をかいてみよう\nノートの前でメニューを開き,Zキーでアイテムを使用できる　");






        }

        if ((TF.nazoflag[6] == true) && (TF.nazoflag[7] == false))
        {

            context.TextActive("チュートリアル終わり\nZキーでタイトルに戻ります");





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






