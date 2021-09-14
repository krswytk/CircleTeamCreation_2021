using System;//会話テロップ用追加点
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roker : MonoBehaviour
{

    [SerializeField]


    public Fungus.Flowchart flowchart = null;//会話テロップ用追加点
    public String sendMessage = "";　　　　　//会話テロップ用追加点

   /* PanelManager context;
    Menu menu;
    ItemManager manager;
    CursorCtrl cursor;
    Flag f;
    static Flag TF;
    */


    // Start is called before the first frame update
    void Start()
    {
        /*menu = GameObject.FindGameObjectWithTag("Player").GetComponent<Menu>();
        manager = GameObject.FindGameObjectWithTag("Player").GetComponent<ItemManager>();
        cursor = GameObject.Find("Canvas").transform.Find("ItemMenu/Cursor").GetComponent<CursorCtrl>();
        f = GameObject.FindGameObjectWithTag("Player").GetComponent<Flag>();
        context = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();
        */
    }

    // Update is called once per frame
    void Update()
    {
        





    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        {
          
                if (Input.GetKeyDown(KeyCode.Z))
                {

                String sendMessage = "ロッカー";
                flowchart.SendFungusMessage(sendMessage);
            }
            
        }
    }

}


