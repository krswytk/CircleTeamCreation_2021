using System;//会話テロップ用追加点
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RikaHinto : MonoBehaviour
{
    PanelManager context;
    public int page;
    public bool a;

    public Fungus.Flowchart flowchart = null;//会話テロップ用追加点
    public String sendMessage = "";　　　　　//会話テロップ用追加点


    // Start is called before the first frame update
    void Start()
    {
        a = false;
        page = 15;
        context = GameObject.FindWithTag("PanelManager").GetComponent<PanelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            

                String sendMessage = "1";//会話テロップ用追加点
                flowchart.SendFungusMessage(sendMessage);//会話テロップ用追加点
               
            
        }

    }


}