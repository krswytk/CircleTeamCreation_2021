using UnityEngine;

public class Tutoriaruinf : MonoBehaviour
{
    [SerializeField]
    
    PanelManager context;
    Menu menu;
    ItemManager manager;
    CursorCtrl cursor;
    Flag f;
    static Flag TF;

    int keyput=0;

    // Start is called before the first frame update
    void Start()
    {

        menu = GameObject.Find("Player (1)").GetComponent<Menu>();
        manager = GameObject.Find("Player (1)").GetComponent<ItemManager>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();
        f = GameObject.Find("Player (1)").GetComponent<Flag>();
        context = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();
        TF=GameObject.Find("Player (1)").GetComponent<Flag>();

        Tyutorial();
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
            if (Input.GetKeyUp(KeyCode.LeftShift) && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
            {
                if ( (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow)))
                {

                    TF.nazoflag[2] = true;
                }
            }
        }


        if ((TF.nazoflag[2] == true) && (TF.nazoflag[3] == false))
        {

            context.TextActive("アイテムの前で決定キー(Z)でアイテムを所得できる");
            if (Input.GetKeyUp(KeyCode.LeftShift) && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
            {
                if ((Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow)))
                {

                    TF.nazoflag[3] = true;
                }
            }
        }






    }




    void Tyutorial()
    {











    }











}
