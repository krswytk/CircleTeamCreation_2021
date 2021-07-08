using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class HokenNazo : MonoBehaviour
{
    PanelManager context;
    Menu menu;
    ItemManager manager;
    CursorCtrl cursor;
    Flag f;
    static Flag TF;
    int a=3;

    public GameObject Key;

    // Start is called before the first frame update
    void Start()
    {
       

        menu = GameObject.FindGameObjectWithTag("Player").GetComponent<Menu>();
        manager = GameObject.FindGameObjectWithTag("Player").GetComponent<ItemManager>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();
        f = GameObject.FindGameObjectWithTag("Player").GetComponent<Flag>();
        context = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();
        TF = GameObject.FindGameObjectWithTag("Player").GetComponent<Flag>();
        if (f.nazoflag[0] == true)
        {

            this.gameObject.SetActive(false);



        }
        else { Key.gameObject.SetActive(false); };


    }

    // Update is called once per frame
    void Update()
    {
    
    }
    private void OnTriggerStay(Collider Player)
    {




        if (Input.GetKeyUp(KeyCode.Z)&&menu.opcl!= true)
        {
   
            context.TextActive("次亜塩素酸だ");


            a = 0;

        }





        if (menu.opcl == true)
            {
                if (manager.itemkind[cursor.getcursor()] == 4)//種類が０に分類されいているアイテムが選択されたら板3
                {
                    if (Input.GetKeyUp(KeyCode.Z)&&a==0)
                    {

                        manager.useitem();//アイテム消費
                       this. gameObject.SetActive(false);
                    Key.gameObject.SetActive(true);
                    f.nazoflag[2] = true;//謎を解いた

                    //  g.SetActive(true);//出口出現
                    // gameObject.SetActive(false);//謎床非表示

                }
                }
            }

        }





    }



