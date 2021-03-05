using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{

   public Image[] gazou;
    int n = 0;//後で決める選択カーソルの番号

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {/*
        //メニューを開いているかどうか
        if (m.opcl == true)
        {
            //アイテム使用
            if (Input.GetKeyDown(KeyCode.Z))
            {
                gazou[n].sprite = null;
                for(int i = 0; i < gazou.Length-(n+1); i++)
                {
                    gazou[n+i].sprite = gazou[n+ i+1].sprite;
                }
                gazou[gazou.Length-1].sprite = null;
            }

        }*/
    }

    public void useitem()
    {
        gazou[n].sprite = null;
        for (int i = 0; i < gazou.Length - (n + 1); i++)
        {
            gazou[n + i].sprite = gazou[n + i + 1].sprite;
        }
        gazou[gazou.Length - 1].sprite = null;
    }
    
    public void getitem(Sprite s)//アイテムの画像を移行
    {
        for (int i = 0; i < gazou.Length; i++)
        {
            if (gazou[i].GetComponent<Image>().sprite == null)
            {
                gazou[i].GetComponent<Image>().sprite = s;
                break;
            }
        }
    }

}
