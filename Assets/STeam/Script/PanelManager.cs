using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    Panel Telop;
    string itemtext;
    [SerializeField]
    GameObject Telopmanager;

    float timer;
    bool item, text;
    // Start is called before the first frame update
    void Start()
    {   
        Telop = Telopmanager.GetComponent<Panel>();
    }

    // Update is called once per frame
    void Update()
    {
        if (item==true||text==true) {
            timer += Time.deltaTime;
        }
        if (timer >= 2.0f)
        {
            panelflag();
            timer = 0;
        }

    }

    public void itempanel(string name)
    {
        item = true;
        Telopmanager.SetActive(true);//テロップ表示
        Telopmanager.transform.Find("Text").gameObject.GetComponent<Text>().text = name + "を手に入れた";//入手したアイテムを表示
        //Invoke("panelflag", 2.0f);
    }

    public void TextActive(string textname)
    {
        text = true;
        Telopmanager.SetActive(true);
        Telopmanager.transform.Find("Text").gameObject.GetComponent<Text>().text = textname;
        //Invoke("Panelflag", 2.0f);
       // Debug.Log("呼び出し");
    }

    void panelflag()
    {
        Telopmanager.SetActive(false);
        item = false;
        text = false;
    }


}
