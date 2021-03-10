using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    Flag f;

    public GameObject parent;

    public Image[] gazou;

    int n = 0;//後で決める選択カーソルの番号

    // Start is called before the first frame update
    void Start()
    {
        f = GetComponent<Flag>();

        gazou = new Image[parent.transform.childCount];
        for (int i = 0; i < gazou.Length; i++)
        {
            gazou[i] = parent.transform.GetChild(i).GetComponent<Image>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void useitem()
    {

        //if(使ったらなくなるアイテムの itemkind==○○とやってロスト処理を制限)
        gazou[n].sprite = null;
        for (int i = 0; i < gazou.Length - (n + 1); i++)
        {
            gazou[n + i].sprite = gazou[n + i + 1].sprite;
        }
        f.itemhave[n] = false;
        //gazou[gazou.Length].sprite = null;
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
