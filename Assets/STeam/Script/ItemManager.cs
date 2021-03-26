using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    //主にアイテムの画像処理


    //カーソルのスクリプトを触りたいので取得(非表示なので)
    [SerializeField]
    GameObject cursor;

    Flag f;

    //クラス　カーソル 
    CursorCtrl cursornum;

    //シーン引継ぎの時に配列の大きさ(子の数)を合わせるために子の親であるobjを取得
    public GameObject parent;

    public Image[] gazou;

    //所持しているアイテムの種類　順番は取得した順
    public int[] itemkind;

    //持っているアイテムの個数　カーソルの上限やアイテムの配列の大きさが決まる
    private int havecount = 0;

   
    private void Start()
    {
        f = GetComponent<Flag>();
        cursornum = cursor.GetComponent<CursorCtrl>();
        /*
        itemkind = new int[parent.transform.childCount];
        for (int i = 0; i < itemkind.Length; i++)
        {
            itemkind[i] = -1;//アイテムの種類を全て-1で初期化
        }*/

        //配列の初期化
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

    public void useitem()//アイテムを消費する時は必ず呼び出す
    {
        //うわって思うかもしれないけど、cursornum.getcursor()←これはただの整数　カーソルが何番を指しているか


        //カーソルで選択した画像の場所を削除、消したところを詰める
        gazou[cursornum.getcursor()].sprite = null;
        //f.itemhave[itemkind[cursornum.getcursor()]] = false;
        itemkind[cursornum.getcursor()] = -1;

        for (int i = 0; i < gazou.Length - (cursornum.getcursor() + 1); i++)
        {
            gazou[cursornum.getcursor() + i].sprite = gazou[cursornum.getcursor() + i + 1].sprite;//画像
            itemkind[cursornum.getcursor() + i] = itemkind[cursornum.getcursor() + i + 1];//アイテムの種類
        }

        decount();//なくなったので
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

    public int getcount()
    {
        return havecount;
    }

    public void setcount(int n)
    {
        havecount = n;
    }

    public void incount()
    {
        havecount++;
    }

    public void decount()
    {
        havecount--;
    }
}
